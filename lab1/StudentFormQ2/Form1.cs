namespace StudentFormQ2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox2.Text, out int result))
            {
            }
            else
                MessageBox.Show("Only enter numbers...");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String exams = "";
            String message;
            if (checkBox1.Checked)
                exams += checkBox1.Text + " ";
            if (checkBox2.Checked)
                exams += checkBox2.Text + " ";
            if (checkBox3.Checked)
                exams += checkBox3.Text + " ";

            message = "Confirm Registration\n\n" +
                "Full Name: " + textBox1.Text + "\n" +
                "Registration ID: " + textBox2.Text + "\n" +
                "Gender: " + (radioButton1.Checked ? "Male" : "Female") + "\n" +
                "Exams Given: " + exams + "\n" +
                "DOB: " + monthCalendar1.SelectionStart.ToString("yyyy-MM-dd") + "\n";
            MessageBox.Show(message);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
