open System
open System.Windows.Forms
open ScfProjectDesign

[<EntryPoint; STAThread>]
let main argv =
    Application.EnableVisualStyles()
    Application.SetCompatibleTextRenderingDefault(false)
    use form = new ScfProjectForm()
    Application.Run(form)    
    0 // return an integer exit code
