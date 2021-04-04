// Copyright Fabulous contributors. See LICENSE.md for license.
namespace AllViewSamplesFfXF

open Fabulous
open Fabulous.XamarinForms
open Xamarin.Forms
open Helpers

module SampleDisplays =
    let sampleDisplays (style: MyStyle) = [
        {   Name = "CarouselView";  
            SampleType = "basic";
            Page = 
                View.ContentPage(
                    title ="CarouselView", 
                        content = 
                            View.CarouselView(items = [
                                View.Label
                                    (
                                        horizontalOptions = style.Position,
                                        verticalOptions = style.Position,
                                        backgroundColor = style.ViewColor,
                                        padding = style.Padding,  
                                        text = ("First CarouselView")
                                    )
                                View.Label
                                    (
                                        horizontalOptions = style.Position,
                                        verticalOptions = style.Position,
                                        backgroundColor = style.ViewColor,
                                        padding = style.Padding,  
                                        text = ("Second CarouselView")
                                    )
                                View.Label
                                    (
                                        horizontalOptions = style.Position,
                                        verticalOptions = style.Position,
                                        backgroundColor = style.ViewColor,
                                        padding = style.Padding,  
                                        text = ("Third CarouselView")
                                    )
                            ] )
                )
        }
        {   Name = "CollectionView";  
            SampleType = "basic";
            Page = 
                View.ContentPage(
                    title ="CollectionView", 
                        content = 
                            View.CarouselView(items = [
                                View.Label
                                    (
                                        horizontalOptions = style.Position,
                                        verticalOptions = style.Position,
                                        backgroundColor = style.ViewColor,
                                        padding = style.Padding,  
                                        text = ("First CollectionView")
                                    )
                                View.Label
                                    (
                                        horizontalOptions = style.Position,
                                        verticalOptions = style.Position,
                                        backgroundColor = style.ViewColor,
                                        padding = style.Padding,  
                                        text = ("Second CollectionView")
                                    )
                                View.Label
                                    (
                                        horizontalOptions = style.Position,
                                        verticalOptions = style.Position,
                                        backgroundColor = style.ViewColor,
                                        padding = style.Padding,  
                                        text = ("Third CollectionView")
                                    )
                            ] )
                )
        }        
        {   Name = "IndicatorView";  
            SampleType = "basic";
            Page = 
                let indicatorRef = ViewRef<IndicatorView>()
                View.ContentPage( 
                    backgroundColor = style.PageColor,
                    title = "IndicatorView", 
                        content = 
                            View.StackLayout
                                ( 
                                    children = [
                                        View.IndicatorView
                                            (
                                                ref = indicatorRef, 
                                                indicatorColor = Color.Red, 
                                                selectedIndicatorColor = Color.Blue, 
                                                padding = style.Padding,  
                                                indicatorsShape = IndicatorShape.Square
                                            )
                    
                                        View.CarouselView
                                            (
                                                indicatorView = indicatorRef, 
                                                items = [
                                                    for i = 0 to 15 do
                                                        yield View.StackLayout
                                                            (   
                                                                horizontalOptions = style.Position,
                                                                verticalOptions = style.Position,
                                                                backgroundColor = style.LayoutColor,
                                                                padding = style.Padding,  
                                                                children = [
                                                                    View.Label
                                                                        (
                                                                            horizontalOptions = style.Position,
                                                                            verticalOptions = style.Position,
                                                                            backgroundColor = style.ViewColor,
                                                                            padding = style.Padding,  
                                                                            text = sprintf "CarouselView %i" i
                                                                        )
                                                            ] )
                                                ]    
                                            )
                                    ] )
                )
        }
        {   Name = "ListView";  
            SampleType = "basic";
            Page = 
                View.TabbedPage
                    (
                        title ="ListView",
                        children = [
                            View.ContentPage(title = "ListView", content = 
                                View.ListView(items = [
                                    View.TextCell "Ionide"
                                    View.TextCell "Visual Studio"
                                    View.TextCell "Emacs"
                                    View.TextCell "Visual Studio Code"
                                    View.TextCell "JetBrains Rider"
                                ](*, itemSelected = (fun idx -> dispatch (ListViewSelectedItemChanged idx)) )*) ) )         
                            View.ContentPage(title = "ListViewGrouped", content = 
                                View.ListViewGrouped(items = [
                                    "Group 1", View.TextCell "Group 1", [View.TextCell "Ionide"; View.TextCell "Visual Studio"; View.TextCell "Emacs"]
                                    "Group 2", View.TextCell "Group 2", [View.TextCell "Visual Studio Code"; View.TextCell "Visual Studio"]                                     
       
                                ](*, itemSelected = (fun idx -> dispatch (ListViewSelectedItemChanged idx)) )*) ) )
                        ] 
                    )
        }
        {   Name = "Picker";  
            SampleType = "basic";
            Page = 
                let pickerItems =
                    [  ("Aqua", Color.Aqua); ("Black", Color.Black);
                       ("Blue", Color.Blue); ("Fucshia", Color.Fuchsia);
                       ("Gray", Color.Gray); ("Green", Color.Green);
                       ("Lime", Color.Lime); ("Maroon", Color.Maroon);
                       ("Navy", Color.Navy); ("Olive", Color.Olive);
                       ("Purple", Color.Purple); ("Red", Color.Red);
                       ("Silver", Color.Silver); ("Teal", Color.Teal);
                       ("White", Color.White); ("Yellow", Color.Yellow ) ]
                
                let pickedColorIndex = 2 // placeholder for testing purposes 
                View.ContentPage(title ="Picker", content =                     
                    View.Picker
                        (
                            title = "Choose Color:",
                            textColor = snd pickerItems.[pickedColorIndex],
                            selectedIndex = pickedColorIndex,
                            items = List.map fst pickerItems
                            //selectedIndexChanged = (fun (i, item) -> dispatch (PickerItemChanged i))
                        )
                )
        }
        {   Name = "TableView";  
            SampleType = "basic";
            Page = 
                View.ContentPage(title ="TableView", content = 
                    View.TableView( root = 
                        View.TableRoot( items = [
                            View.TableSection
                                (
                                    title = "Videos",
                                    items = [
                                        View.SwitchCell(on = true, text = "Luca 2008") 
                                        View.SwitchCell(on = true, text = "Don 2010")
                                    ]
                                )
                            View.TableSection
                                (
                                    title = "Books",
                                    items = [
                                        View.SwitchCell(on = true, text = "Expert F#") 
                                        View.SwitchCell(on = false, text = "Programming F#")
                                    ]
                                )
                            View.TableSection
                                (
                                    title = "Contact",
                                    items = [
                                        View.EntryCell(label = "Email", placeholder = "foo@bar.com")
                                        View.EntryCell(label = "Phone", placeholder = "+44 87654321")
                                    ]
                                )
                        ] )
                    )
                )
        }
    ]