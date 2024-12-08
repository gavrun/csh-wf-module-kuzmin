using System.Runtime.InteropServices;

namespace Lec05Ex01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            MoveFile("my.txt", "my2.txt");

        }
        [DllImport("KERNEL32.DLL", EntryPoint = "MoveFileW", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern bool MoveFile(String src, String dst);

        [System.Flags]
        public enum PlaySoundFlags : int
        {
            SND_SYNC = 0x0000,
            SND_ASYNC = 0x0001,
            SND_NODEFAULT = 0x0002,
            SND_LOOP = 0x0008,
            SND_NOSTOP = 0x0010,
            SND_NOWAIT = 0x00002000,
            SND_FILENAME = 0x00020000,
            SND_RESOURCE = 0x00040004
        }

        [DllImport("winmm.DLL", EntryPoint = "PlaySound", SetLastError = true, CharSet = CharSet.Unicode, ThrowOnUnmappableChar = true)]
        private static extern bool PlaySound(string szSound, System.IntPtr hMod, PlaySoundFlags flags);

        private void btnSelectAudio_Click(object sender, EventArgs e)
        {
            var dgFile = new OpenFileDialog();
            dgFile.InitialDirectory = @"C:\C#\202411\Workspace\Lec05Ex01";
            dgFile.Filter = "Wav files (*.wav)|*.wav";
            dgFile.FilterIndex = 2;
            dgFile.RestoreDirectory = true;

            if (dgFile.ShowDialog() == DialogResult.OK) {
                txtFileName.Text = dgFile.FileName;
                Thread thread = new Thread(new ThreadStart(Worker));
                thread.Start();
            }
            /*
             * int c;
             * int* ptr = &c;
             * c = 9;
             * (*ptr) = 9;
             * */
        }

        private void Worker()
        {
            PlaySound(txtFileName.Text, new System.IntPtr(), PlaySoundFlags.SND_SYNC);
        }

    }
}
