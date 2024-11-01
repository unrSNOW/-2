namespace Практическая_работа_2
{
    public partial class Form1 : Form
    {
        private volatile bool isRunning;

        public Form1()
        {
            InitializeComponent();
            foreach (var priority in Enum.GetNames(typeof(ThreadPriority)))
            {
                cmbNumbers.Items.Add(priority);
                cmbLetters.Items.Add(priority);
                cmbSymbols.Items.Add(priority);
            }
            cmbNumbers.SelectedIndex = cmbLetters.SelectedIndex = cmbSymbols.SelectedIndex = 2; // Normal
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            isRunning = true;
            StartThread(() => GenerateData(() => new Random().Next(0, 100).ToString()), cmbNumbers);
            StartThread(() => GenerateData(() => ((char)new Random().Next('A', 'Z' + 1)).ToString()), cmbLetters);
            StartThread(() => GenerateData(() => ((char)new Random().Next(33, 48)).ToString()), cmbSymbols);
        }
        private void StartThread(Action action, ComboBox comboBox)
        {
            var thread = new Thread(new ThreadStart(action))
            {
                Priority = (ThreadPriority)Enum.Parse(typeof(ThreadPriority), comboBox.SelectedItem.ToString())
            };
            thread.Start();
        }
        private void GenerateData(Func<string> getRandom)
        {
            while (isRunning)
            {
                string result = getRandom();
                Invoke((Action)(() => textBoxOutput.AppendText(result + Environment.NewLine)));
                Thread.Sleep(1000);
            }
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            isRunning = false;
        }

    }
}
