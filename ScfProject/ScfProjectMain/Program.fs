open System
open System.Windows.Forms
open ScfProjectDesign

[<EntryPoint; STAThread>]
let main argv =
    Application.EnableVisualStyles()
    Application.SetCompatibleTextRenderingDefault(false)
    use form = new ScfProjectForm()
    Application.Run(form)    
    printfn "%A" argv
    0 // return an integer exit code
