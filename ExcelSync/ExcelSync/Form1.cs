using IronXL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelSync
{
    public partial class Form1 : Form
    {
        private string selectedFilePath;

        public Form1()
        {
            InitializeComponent();
            importButton.Visible = false;
            progressBar.Visible = false;
            selectFilePath.Visible = false;
            status.Visible = false;
            filepath.Visible = false;
            reportButton.Visible = false;
        }

        //The following functions the same as excelToCSV's File Selection code.
        private void selectFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog(); // Open a select file dialogue box.
            openFileDialog1.Filter = "Excel Files|*.xls;*.xlsx"; // Filters to only show .xlsx files.
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.

            if (result == DialogResult.OK) // Test result.
            {
                selectedFilePath = openFileDialog1.FileName; //Get the file name.
                string path = Path.GetFullPath(selectedFilePath); //Get full path of the tile.
                selectFilePath.Text = "Selected " + path; //Display the selected filepath.
                importButton.Visible = true; //Show the importButton.
                selectFilePath.Visible = true; //Show the selected filepath.
            }
        }

        //This is some fake code to show how a progress bar would work.
        private void importButton_Click(object sender, EventArgs e)
        {
            selectFileButton.Enabled = false; //While the progress bar is working, you cannot click the Select File Button.
            progressBar.Visible = true; //Show the progress bar.
            status.Visible = true; //Show the status label.
            filepath.Visible = true; //Show the status (this is filepath for now).
            BackgroundWorker worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;

            worker.DoWork += (obj, args) =>
            {
                //Simulating the import process.
                for (int i = 1; i <= 5; i++)
                {
                    //Report progress and update the status message.
                    string statusMessage = GetStatusMessage(i);
                    worker.ReportProgress(i * 20, statusMessage); //i(5) * 20 = 100%
                    System.Threading.Thread.Sleep(1000); // Simulating 1 second per task.
                }
            };

            worker.ProgressChanged += (obj, args) =>
            {
                //Update the progress bar and status message.
                progressBar.Value = args.ProgressPercentage;
                filepath.Text = args.UserState.ToString();
            };

            worker.RunWorkerCompleted += (obj, args) =>
            {
                reportButton.Visible = true; //When the progress bar is finished, the View Report button should become visible.
                selectFileButton.Enabled = true; //While the progress bar is finished, you cannot select another file.
            };

            //Start the background worker.
            worker.RunWorkerAsync();
        }

        //Method to get the status message based on progress.
        private string GetStatusMessage(int progress)
        {
            switch (progress)
            {
                case 1: return "Importing Payment Terms...";
                case 2: return "Importing Chart of Accounts...";
                case 3: return "Importing Customers...";
                case 4: return "Importing Vendors...";
                case 5: return "Import Succesfully Completed!";
                default: return "";
            }
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            this.Hide(); //Hides Connector Page after clicking Report button.
            Form2 report = new Form2();
            report.Show(); //Shows Report Form.
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            //no logic yet
        }

        //The following functions the same as excelToCSV's conversion code.
        /*This is just example placeholder code. For now, we won't delete it.
        if (string.IsNullOrEmpty(selectedFilePath)) //Check to see if there has been a file selected.
        {
            status.Text = "Please select a file first.";
            return;
        }

        try
        {
            WorkBook wb = WorkBook.Load(selectedFilePath); //The excel document is loaded from the string.
            WorksheetsCollection WSC = wb.WorkSheets; //All worksheets are put into an array basically.

            foreach (WorkSheet ws in WSC) //For each page in the excel file.
            {
                SaveFileDialog saveFileDialogue = new SaveFileDialog();
                saveFileDialogue.ShowDialog(); //Select where to save a file. The filename must have the .csv extension.
                string savePath = saveFileDialogue.FileName; //The path to output the CSV to.
                int index = savePath.LastIndexOf('.');
                if (index >= 0) //Prevents a specified argument being outside the range of valid values.
                {
                    savePath = savePath.Insert(index, "_" + ws.Name);
                }
                else
                {
                    savePath = savePath + "_" + ws.Name; // Handle the case where there is no file extension.
                }
                filepath.Text = savePath; //Show the saved path in the program.
                ws.SaveAsCsv(savePath); //Each page is outputted as a CSV one by one.
            }
            status.Text = "Try Statement Successfully Completed!";
        }
        catch (Exception ex)
        {
        status.Text = "Try Statement Failed...";
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }*/
    }
}
