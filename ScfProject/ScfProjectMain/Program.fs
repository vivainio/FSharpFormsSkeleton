module ScfProject.Main

open System
open System.Windows.Forms
open ScfProjectDesign

open TrivialBehind


type ScfProjectBehind(ui: ScfProjectUi) = 
    let mutable counter = 0;
    do
        ui.button1.Click.Add <| fun _ ->
            counter <- counter + 1
            ui.label1.Text <- sprintf "Lorem ipsum %d" counter

let registerBehinds() =
    TrivialBehinds.RegisterBehind<ScfProjectUi, ScfProjectBehind>()
    

[<EntryPoint; STAThread>]
let main argv =
    Application.EnableVisualStyles()
    Application.SetCompatibleTextRenderingDefault(false)
    registerBehinds()
    use form = new ScfProjectForm()
    Application.Run(form)    
    0 // return an integer exit code
