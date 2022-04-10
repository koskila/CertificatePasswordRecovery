using CertificatePasswordRecovery;
using System.Threading;
using System.Windows.Forms;

//It is unfortunate but we have to set it to Unknown first
//https://github.com/dotnet/winforms/issues/5071
Thread.CurrentThread.SetApartmentState(ApartmentState.Unknown);
Thread.CurrentThread.SetApartmentState(ApartmentState.STA);

Application.SetHighDpiMode(HighDpiMode.SystemAware);
Application.EnableVisualStyles();
Application.SetCompatibleTextRenderingDefault(false);

Application.Run(new CertPasswordRecoveryForm());