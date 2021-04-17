// Copyright Fabulous contributors. See LICENSE.md for license.
namespace AllViewSamplesFfXF

open Fabulous
open Fabulous.XamarinForms
open Xamarin.Forms
open Helpers

module App =  
 
    /// The messages dispatched by the view
    type Msg =        
        | IsFlyoutPresentedChanged of bool
        | ListViewSelectedItemChanged of (int * int)
        | StateChanged
        | ChangeMyStyle
        | ResetStyle
 
    /// The model from which the view is generated
    type Model =
        {   SelectedPage : (int * int)
            IsFlyoutPresented : bool
            StateChanged : bool 
            MyStyle : MyStyle 
        }
 
    /// Returns the initial state
    let init() = 
        {   SelectedPage = (0, 0)
            IsFlyoutPresented = false
            StateChanged = false 
            MyStyle = myStyle
        }, Cmd.none
 
    /// The function to update the view
    let update (msg: Msg) (model: Model) =
        match msg with
        | IsFlyoutPresentedChanged b -> 
            {model with IsFlyoutPresented = b}, Cmd.none
        | ListViewSelectedItemChanged i -> 
            {model with SelectedPage = i; IsFlyoutPresented = false}, Cmd.none
        | StateChanged -> 
            { model with StateChanged = true }, Cmd.none
        | ChangeMyStyle ->
            if (model.MyStyle = myStyle)
                then {model with MyStyle = noStyle}, Cmd.none
            else {model with MyStyle = myStyle}, Cmd.none
        | ResetStyle -> {model with MyStyle = myStyle}, Cmd.none
            
 
    /// The view function giving updated content for the page
    let view (model: Model) dispatch =        

        let introductionPages = [
            {   Name = "Introduction";
                SampleType = "basic";
                Page = 
                    View.ContentPage
                        (
                            backgroundColor = model.MyStyle.PageColor,
                            padding = model.MyStyle.Padding,
                            content = 
                                //View.Label
                                //    (
                                //        horizontalOptions = model.MyStyle.Position,
                                //        verticalOptions = model.MyStyle.Position,
                                //        backgroundColor = model.MyStyle.ViewColor,
                                //        padding = model.MyStyle.Padding,
                                //        text = "NavigationPage"
                                //    )
                                View.StackLayout
                                    (                                        
                                        horizontalOptions = model.MyStyle.Position,
                                        verticalOptions = model.MyStyle.Position,
                                        backgroundColor = model.MyStyle.LayoutColor,
                                        padding = model.MyStyle.Padding,
                                        children = [
                                            View.Label
                                                (
                                                    text = "Welcome",
                                                    horizontalOptions = model.MyStyle.Position,
                                                    verticalOptions = model.MyStyle.Position,
                                                    backgroundColor = model.MyStyle.ViewColor,
                                                    padding = model.MyStyle.Padding
                                                )        
                                            View.Button
                                                (
                                                    text = "Toggle Style", 
                                                    horizontalOptions = model.MyStyle.Position,
                                                    verticalOptions = model.MyStyle.Position,
                                                    backgroundColor = model.MyStyle.ButtonColor,
                                                    padding = model.MyStyle.Padding,
                                                    command = fun () -> (dispatch ChangeMyStyle)
                                                )
                                        ]
                                    )
                            
                        )            
            }
        ]

        let pagesToNavigateName (p : list<SamplePage>) = p |> List.map (fun x -> View.TextCell(text = x.Name, textColor = Color.DarkGray))
        let activePage x = 
            let activeCategory =
                match fst(x) with                
                | 0 -> introductionPages
                | 1 -> SamplePages.samplePages model.MyStyle
                | 2 -> SampleLayouts.sampleLayouts model.MyStyle
                | 3 -> SampleDisplays.sampleDisplays model.MyStyle
                | 4 -> SampleEdit.sampleEdit model.MyStyle
                | 5 -> SampleIndicate.sampleIndicate model.MyStyle
                | 6 -> SampleSetting.sampleSetting model.MyStyle
                | 7 -> SampleInitiate.sampleInitiate model.MyStyle
                | 8 -> SamplePresent.samplePresent model.MyStyle
                | _ -> []
            activeCategory.Item(snd(x)).Page
        
        View.FlyoutPage(   
            flyoutLayoutBehavior = FlyoutLayoutBehavior.Default,
            isPresented = model.IsFlyoutPresented,
            isPresentedChanged = (fun () -> dispatch (IsFlyoutPresentedChanged (not model.IsFlyoutPresented))),

            flyout = View.ContentPage
                (   title ="flyoutPage",    
                    content = 
                        View.Grid
                            (
                                rowdefs = [
                                    Dimension.Auto
                                ],
                                coldefs = [
                                    Dimension.Auto
                                    Dimension.Auto
                                    Dimension.Star
                                ],
                                children = [
                                    View.Label("basic").Column(0)
                                    View.Switch(isToggled = false).Column(1)
                                    View.Label("advanced samples").Column(2)
                                    View.ListViewGrouped(
                                        items = [                                    
                                            "Introduction Pages", View.TextCell("Introduction Pages", textColor = Color.LightGray), (pagesToNavigateName introductionPages)
                                            "Sample Pages", View.TextCell("Sample Pages", textColor = Color.LightGray), pagesToNavigateName (SamplePages.samplePages model.MyStyle)
                                            "Sample Layouts", View.TextCell("Sample Layouts", textColor = Color.LightGray), pagesToNavigateName (SampleLayouts.sampleLayouts model.MyStyle)
                                            "Sample Displays", View.TextCell("Sample Displays", textColor = Color.LightGray), pagesToNavigateName (SampleDisplays.sampleDisplays model.MyStyle)
                                            "Sample Edit", View.TextCell("Sample Edit", textColor = Color.LightGray), pagesToNavigateName (SampleEdit.sampleEdit model.MyStyle)
                                            "Sample Indicate", View.TextCell("Sample Indicate", textColor = Color.LightGray), pagesToNavigateName (SampleIndicate.sampleIndicate model.MyStyle)
                                            "Sample Setting", View.TextCell("Sample Setting", textColor = Color.LightGray), pagesToNavigateName (SampleSetting.sampleSetting model.MyStyle)
                                            "Sample Initiate", View.TextCell("Sample Initiate", textColor = Color.LightGray), pagesToNavigateName (SampleInitiate.sampleInitiate model.MyStyle)
                                            "Sample Present", View.TextCell("Sample Present", textColor = Color.LightGray), pagesToNavigateName (SamplePresent.samplePresent model.MyStyle)
                                        ], 
                                        itemSelected = (fun idx -> dispatch (ListViewSelectedItemChanged idx.Value); dispatch (ResetStyle))
                                    ).Row(1).ColumnSpan(3)
                                ]
                            )
                ), 
            detail = View.NavigationPage
                (   title = "details", 
                    toolbarItems = [
                        View.ToolbarItem
                            (
                                text = "toggle style",
                                command = fun () -> (dispatch ChangeMyStyle)
                            )
                    ],
                    pages = [
                        activePage model.SelectedPage
                    ] 
                )
        )
    
type App () as app =
    inherit Application ()
 
    let runner =        
        Program.mkProgram App.init App.update App.view
        |> Program.withConsoleTrace
        |> XamarinFormsProgram.run app
