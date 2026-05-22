namespace File_Organizer
{
    public partial class Form1 : Form
    {

        protected string FolderPath; // the path to the folder to organize
        protected List<string> FileNames = new List<string>(); // these are going to be all the file names
        public Form1() // init the window
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // make so that the size of the window cannot be changable
            this.MaximizeBox = false; // disallow the maximize button
        }

        /// <summary>
        /// This function is called during the press of the Directory choosing button, it will ask user to 
        /// Provide the path to the folder needed to be organized, add it to the PathLabel to notify the user
        /// and write this to the Class-field FolderPath
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">extra data about the even: (because this is a simple click, it wont take any args)</param>
        private void ChooseDirBtn_Click(object sender, EventArgs e)
        {


            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.FolderPath = folderBrowserDialog1.SelectedPath;

                PathLabel.Text = $"Current Path: {FolderPath}";
            }
        }

        /// <summary>
        /// This function will go to a given directory and add all of the file names to the 
        /// class field FileNames, we need it to then iterate through the file names and not work 
        /// with dirs anymore
        /// </summary>
        /// <param name="_Path">the Path to the folder(gotten from ChooseDirBtn_Click())</param>
        private void AddFilesFromDir(string _Path)
        {
            if (Directory.Exists(_Path))
            {
                // Loops through files one by one (Memory efficient)
                foreach (string filePath in Directory.EnumerateFiles(_Path))
                {
                    this.FileNames.Add(Path.GetFileName(filePath));
                }
            }
        }


        /// <summary>
        /// This is the heart of the code, this function gets called when the user has already given
        /// us the Path(it will notify him to do so if not) to the folder needed. This func will go 
        /// over all of the files in the folder and reposition them inside sub-folders to make the 
        /// appearence of the initial folder more organized
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">extra data about the even: (because this is a simple click, it wont take any args)</param>
        private void StartBtn_Click(object sender, EventArgs e)
        {


            // ensure valid Folder
            if (string.IsNullOrWhiteSpace(this.FolderPath) || !Directory.Exists(this.FolderPath))
            {
                MessageBox.Show(
                    "Please choose a directory first.",
                    "Folder Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
            

            this.FileNames.Clear(); // important if user runs twice
            this.AddFilesFromDir(this.FolderPath);

            // dict of folders and extensions to reassign the files
            var subfolders = new Dictionary<string, string[]>
            {
                { "Photos",    new[] { "png", "jpg", "jpeg", "gif", "bmp", "tiff", "webp" } },
                { "Videos",    new[] { "mp4", "mov", "avi", "mkv", "wmv", "flv", "webm" } },
                { "Documents", new[] { "pdf", "doc", "docx", "txt", "rtf", "xls", "xlsx", "ppt", "pptx" } },
                { "Audio",     new[] { "mp3", "wav", "flac", "aac", "ogg", "m4a" } },
                { "Archives",  new[] { "zip", "rar", "7z", "tar", "gz" } },
                { "Code",      new[] { "cs", "cpp", "c", "py", "js", "html", "css", "java", "php", "json", "xml" } },
                { "Executables", new[] { "exe", "msi", "bat", "cmd" } },
                { "Logs",      new[] { "log" } }
            };




            bool FileAssigned = false;
            foreach (string _File in this.FileNames) // Go over all the files
            {
                FileAssigned = false;
                foreach (var folder in subfolders)
                {
                    if (folder.Value.Contains((Path.GetExtension(_File).TrimStart('.').ToLower()))) // for each file try to find his ending in subfolders.Values
                    {
                        string targetDir = Path.Combine(this.FolderPath, folder.Key); // if the folder doesnt already exist, add it
                        if (!Directory.Exists(targetDir))
                            Directory.CreateDirectory(targetDir);

                        System.IO.File.Copy(Path.Combine(this.FolderPath, _File),
                                  Path.Combine(targetDir, _File));

                        System.IO.File.Delete(Path.Combine(this.FolderPath, _File));
                        FileAssigned = true;
                        break; // so that the same file wouldnt be added to 2 differents dirs if they both have the same extension in Values
                    }
                }
                if (!FileAssigned) // if unknown extension
                {
                    if (!Directory.Exists(Path.Combine(this.FolderPath, "Other")))
                        Directory.CreateDirectory(Path.Combine(this.FolderPath, "Other"));


                    System.IO.File.Copy(Path.Combine(this.FolderPath, _File), Path.Combine(this.FolderPath, "Other", _File)); // if found copy the file to the correct directory
                    System.IO.File.Delete(Path.Combine(this.FolderPath, _File));
                }
            }

            // After all files are processed:
            MessageBox.Show(
                "✔ Sorting completed successfully!",
                "Done",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

        }
    }
}
