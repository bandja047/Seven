using System;
using System.Drawing;
using System.Windows.Forms;

public class ToastNotification : Form
{
    private System.Windows.Forms.Timer timer;

    public ToastNotification(string title, string message, int duration = 3000)
    {
        // Configuration de la fenêtre
        this.FormBorderStyle = FormBorderStyle.None;
        this.StartPosition = FormStartPosition.Manual;
        this.Size = new Size(300, 100);
        this.BackColor = Color.FromArgb(50, 50, 50);
        this.Opacity = 0.9;
        this.TopMost = true;
        this.ShowInTaskbar = false;

        // Position en bas à droite de l'écran
        var screenBounds = Screen.PrimaryScreen.WorkingArea;
        this.Location = new Point(screenBounds.Width - this.Width - 10, screenBounds.Height - this.Height - 10);

        // Ajout du titre
        Label titleLabel = new Label
        {
            Text = title,
            ForeColor = Color.White,
            Font = new Font("Segoe UI", 12, FontStyle.Bold),
            AutoSize = false,
            Size = new Size(this.Width - 20, 30),
            Location = new Point(10, 10)
        };

        // Ajout du message
        Label messageLabel = new Label
        {
            Text = message,
            ForeColor = Color.White,
            Font = new Font("Segoe UI", 10),
            AutoSize = false,
            Size = new Size(this.Width - 20, 50),
            Location = new Point(10, 40)
        };

        // Ajout des contrôles à la fenêtre
        this.Controls.Add(titleLabel);
        this.Controls.Add(messageLabel);

        // Configuration du Timer pour fermer le toast automatiquement
        timer = new System.Windows.Forms.Timer();
        timer.Interval = duration; // Durée en millisecondes
        timer.Tick += (s, e) => { this.Close(); };
        timer.Start();
    }

    public ToastNotification(string title, string message,Color color, int duration = 3000)
    {
        // Configuration de la fenêtre
        this.FormBorderStyle = FormBorderStyle.None;
        this.StartPosition = FormStartPosition.Manual;
        this.Size = new Size(300, 100);
        this.BackColor =color;
        this.Opacity = 0.9;
        this.TopMost = true;
        this.ShowInTaskbar = false;

        // Position en bas à droite de l'écran
        var screenBounds = Screen.PrimaryScreen.WorkingArea;
        this.Location = new Point(screenBounds.Width - this.Width - 10, screenBounds.Height - this.Height - 10);

        // Ajout du titre
        Label titleLabel = new Label
        {
            Text = title,
            ForeColor = Color.White,
            Font = new Font("Segoe UI", 12, FontStyle.Bold),
            AutoSize = false,
            Size = new Size(this.Width - 20, 30),
            Location = new Point(10, 10)
        };

        // Ajout du message
        Label messageLabel = new Label
        {
            Text = message,
            ForeColor = Color.White,
            Font = new Font("Segoe UI", 10),
            AutoSize = false,
            Size = new Size(this.Width - 20, 50),
            Location = new Point(10, 40)
        };

        // Ajout des contrôles à la fenêtre
        this.Controls.Add(titleLabel);
        this.Controls.Add(messageLabel);

        // Configuration du Timer pour fermer le toast automatiquement
        timer = new System.Windows.Forms.Timer();
        timer.Interval = duration; // Durée en millisecondes
        timer.Tick += (s, e) => { this.Close(); };
        timer.Start();
    }
    // Méthode statique pour afficher le toast
    public static void ShowToast(string title, string message, int duration = 3000)
    {
        ToastNotification toast = new ToastNotification(title, message, duration);
        toast.Show();
    }

    public static void ShowToast(string title, string message,Color color, int duration = 3000)
    {
        ToastNotification toast = new ToastNotification(title, message, color,duration);
        toast.Show();
    }
}
