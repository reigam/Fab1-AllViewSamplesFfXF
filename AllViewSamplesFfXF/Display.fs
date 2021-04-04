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
                    backgroundColor = style.PageColor,
                    title ="CarouselView",                         
                        content = 
                            View.CarouselView
                                (
                                    horizontalOptions = style.Position,
                                    verticalOptions = style.Position,
                                    backgroundColor = style.LayoutColor,
                                    items = [
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
                                                backgroundColor = style.ViewColor2,
                                                padding = style.Padding,  
                                                text = ("Second CarouselView")
                                            )
                                        View.Label
                                            (
                                                horizontalOptions = style.Position,
                                                verticalOptions = style.Position,
                                                backgroundColor = style.ViewColor3,
                                                padding = style.Padding,  
                                                text = ("Third CarouselView")
                                            )
                                    ] 
                                )
                )
        }
        {   Name = "CollectionView";  
            SampleType = "basic";
            Page = 
                View.ContentPage(                    
                    backgroundColor = style.PageColor,
                    title ="CollectionView", 
                        content = 
                            View.CollectionView
                                (
                                    horizontalOptions = style.Position,
                                    verticalOptions = style.Position,
                                    backgroundColor = style.LayoutColor,
                                    items = [
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
                                                backgroundColor = style.ViewColor2,
                                                padding = style.Padding,  
                                                text = ("Second CollectionView")
                                            )
                                        View.Label
                                            (
                                                horizontalOptions = style.Position,
                                                verticalOptions = style.Position,
                                                backgroundColor = style.ViewColor3,
                                                padding = style.Padding,  
                                                text = ("Third CollectionView")
                                            )
                                    ] 
                                )
                )
        }        
        
        let indicatorRef = ViewRef<IndicatorView>()
        {   Name = "IndicatorView";  
            SampleType = "basic";
            Page = 
                View.ContentPage( 
                    backgroundColor = style.PageColor,
                    title = "IndicatorView", 
                    content = 
                        View.StackLayout
                            ( 
                                children = [
                                    View.IndicatorView
                                        (   
                                            horizontalOptions = style.Position,
                                            verticalOptions = style.Position,
                                            backgroundColor = style.LayoutColor,
                                            padding = style.Padding,  
                                            ref = indicatorRef, 
                                            indicatorColor = Color.Red, 
                                            selectedIndicatorColor = Color.Blue, 
                                            indicatorsShape = IndicatorShape.Square
                                        )                    
                                    View.CarouselView
                                        (
                                            indicatorView = indicatorRef, 
                                            items = [
                                                View.Label
                                                    (
                                                        horizontalOptions = style.Position,
                                                        verticalOptions = style.Position,
                                                        backgroundColor = style.ViewColor,
                                                        padding = style.Padding,  
                                                        text = ("First CarouselView with IndicatorView")
                                                    )
                                                View.Label
                                                    (
                                                        horizontalOptions = style.Position,
                                                        verticalOptions = style.Position,
                                                        backgroundColor = style.ViewColor2,
                                                        padding = style.Padding,  
                                                        text = ("Second CarouselView with IndicatorView")
                                                    )
                                                View.Label
                                                    (
                                                        horizontalOptions = style.Position,
                                                        verticalOptions = style.Position,
                                                        backgroundColor = style.ViewColor3,
                                                        padding = style.Padding,  
                                                        text = ("Third CarouselView with IndicatorView")
                                                    )

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
                            View.ContentPage(
                                title = "ListView", 
                                    content = 
                                        View.ListView(items = [
                                            View.TextCell "First ListView"; 
                                            View.TextCell "Second ListView"; 
                                            View.TextCell "Third ListView"
                                        ](*, itemSelected = (fun idx -> dispatch (ListViewSelectedItemChanged idx)) )*) ) )         
                            View.ContentPage(
                                title = "ListViewGrouped", 
                                content = 
                                    View.ListViewGrouped(items = [
                                        "Group 1", 
                                        View.TextCell "Group 1", 
                                        [
                                            View.TextCell "First ListView"; 
                                            View.TextCell "Second ListView"; 
                                            View.TextCell "Third ListView"
                                        ]
                                        "Group 2", 
                                        View.TextCell "Group 2", 
                                        [
                                            View.TextCell "Fourth ListView"; 
                                            View.TextCell "Fifth ListView"; 
                                            View.TextCell "Sixth ListView"
                                        ]                                     
       
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
                                    title = "TextCell",
                                    items = [
                                        View.TextCell(text = "First TextCell") 
                                        View.TextCell(text = "Second TextCell")
                                    ]
                                )
                            View.TableSection
                                (
                                    title = "ImageCell",
                                    items = [
                                        View.ImageCell(text = "First ImageCell", image = Image.ImagePath "icon.png") 
                                        View.ImageCell(text = "Second ImageCell", image = Image.ImagePath "icon2.png") 
                                    ]
                                )
                            View.TableSection
                                (
                                    title = "SwitchCell",
                                    items = [
                                        View.SwitchCell(text = "First SwitchCell", isEnabled = false)
                                        View.SwitchCell(text = "Second SwitchCell", isEnabled = true)
                                    ]
                                )
                            View.TableSection
                                (
                                    title = "EntryCell",
                                    items = [
                                        View.EntryCell(label = "First EntryCell", placeholder = "enter text here")
                                        View.EntryCell(label = "Second EntryCell", placeholder = "enter more text here")
                                    ]
                                )
                        ] )
                    )
                )
        }
    ]