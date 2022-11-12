namespace LabTwo.Warnings
{
    public static class WarningDisplayer
    {
        public static void ShowWarning(Panel warningPanel, Label warningText, List<IWarning> warnings)
        {
            warningText.Text = string.Empty; // clear previous text if there is some
            warningText.Text += "Some errors occured:\r\n\r\n";
            foreach (IWarning warning in warnings)
                warningText.Text += "- " + warning.Text + "\r\n";
            warningPanel.Show();
        }
    }
}