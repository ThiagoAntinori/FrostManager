namespace UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            bool mostrarLogin = true;

            while (mostrarLogin)
            {
                mostrarLogin = false;

                using (var login = new LoginForm())
                {
                    if (login.ShowDialog() == DialogResult.OK)
                    {
                        using (var main = new MainForm())
                        {
                            if (main.ShowDialog() == DialogResult.Retry)
                            {
                                mostrarLogin = true;
                            }
                        }
                    }
                }
            }
        }

    }
}