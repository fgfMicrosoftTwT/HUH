Public Class Form1


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Start()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

            DialogResult dialog = MessageBox.Show("Tem program może wyżądzić szkody w systemie Windows, jezeli nie chesz uruchaniać aplikacji kliknij na przycisk No, tak, yes", "Uwaga!", MessageBoxButtons.YesNo));
            If(DialogResult = Windows.Forms.DialogResult.Yes);
            {
            Dim AcessPros = Microsoft.Win32.Registry.CurrentConfig.OpenSubKey("SOFTWARE\\MICROSOFT\\WINDOWS\\CurrentVersion\\Diagnostics\\DiagTrack")
            }

        If(AcessPros == False)
        {
            AcessPros.SetValue(0);
        }

                ServiceController1.DisplayName("DoD")
                ServiceController1.Stop();



    End Sub
