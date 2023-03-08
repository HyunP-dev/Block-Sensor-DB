namespace P2P_Data_Sharer

open Gtk

type MainWindow (builder : Builder) as this =
    inherit Window(builder.GetRawOwnedObject("MainWindow"))
    let mutable _headerBar : HeaderBar = builder.GetObject("HeaderBar") :?> HeaderBar
    do
        _headerBar <- builder.GetObject("HeaderBar") :?> HeaderBar
        _headerBar.ShowCloseButton <- true
        this.DeleteEvent.Add(fun _ ->
            Application.Quit()
        )

    new() = new MainWindow(new Builder("MainWindow.glade"))
