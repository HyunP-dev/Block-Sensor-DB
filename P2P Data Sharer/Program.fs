namespace P2P_Data_Sharer

open System
open Microsoft.AspNetCore.Builder

module Program =

    open Gtk
    open System.IO

    [<EntryPoint>]
    let main argv =
        Application.Init()
        
        match Environment.OSVersion.Platform with
        | PlatformID.Unix -> Console.WriteLine("This system is on UNIX.")
        | PlatformID.Win32Windows -> Console.WriteLine("This system is on Windows.")
        | _ -> Console.WriteLine("What is your OS?")
        
        Server.Run()
        
        // if Environment.OSVersion.Platform.Equals(PlatformID.Unix) then
        //     Console.WriteLine("This system is on UNIX.")
        // Directory.CreateDirectory("/tmp/p2pdatasharer")
        
        let app = new Application("org.P2P_Data_Sharer.P2P_Data_Sharer", GLib.ApplicationFlags.None)
        app.Register(GLib.Cancellable.Current) |> ignore;

        let win = new MainWindow()
        app.AddWindow(win)

        win.Show()
        Application.Run()
        0