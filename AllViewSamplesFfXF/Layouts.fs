// Copyright Fabulous contributors. See LICENSE.md for license.
namespace AllViewSamplesFfXF

open Fabulous
open Fabulous.XamarinForms
open Xamarin.Forms
open Helpers

module SampleLayouts =
    let sampleLayouts (style: MyStyle) = [
        {   Name = "ContentView";  
            Page = 
                View.ContentPage(                    
                    backgroundColor = style.PageColor,
                    title ="ContentView",
                    content = 
                        View.ContentView
                            (
                                horizontalOptions = style.Position,
                                verticalOptions = style.Position,
                                backgroundColor = style.LayoutColor,
                                padding = style.Padding,
                                content = 
                                    View.Label
                                        (
                                            horizontalOptions = style.Position,
                                            verticalOptions = style.Position,
                                            backgroundColor = style.ViewColor,
                                            padding = style.Padding,
                                            text = "ContentView"
                                        )
                            )
                )
        }
        {   Name = "Frame"; 
            Page = 
                View.ContentPage(title ="Frame", content = 
                    View.Frame( hasShadow = true, 
                                backgroundColor = Color.Fuchsia,
                                content = View.Label("Frame")
                    )      
                )
        }
        {   Name = "ScrollView"; 
            Page = 
                View.ContentPage(title ="ScrollView", content = 
                    View.ScrollView( content = 
                        View.StackLayout( children = [
                            for i in 1 .. 100 -> View.Label(text = sprintf "item %i" i)
                        ] )
                    )   
                )
        }
        {   Name = "StackLayout"; 
            Page = 
                View.ContentPage(title ="StackLayout", content = 
                    View.StackLayout
                        ( children = [
                            View.Label("stacked label")
                            View.Button(text = "stacked button")
                            View.Label("stacked label")
                        ] )   
                )
        }
        {   Name = "Grid"; 
            Page = 
                View.ContentPage(title ="Grid", content = 
                    View.Grid
                        (
                            rowdefs = [
                                Dimension.Auto              // first row = .Row(0)
                                Dimension.Absolute 150.     // second row = .Row(1)
                                Dimension.Auto              // third row = .Row(2)
                                Dimension.Star              // fourth row = .Row(3)
                            ],
                            coldefs = [
                                Dimension.Absolute 200.     // first column = .Column(0)
                                Dimension.Star              // second column = .Column(1)
                            ],
                            children = [
                                View.Label(text = "first row", backgroundColor = Color.Red).Row(0)                    
                                View.Label(text = "second row", backgroundColor = Color.Blue).Row(1)
                                View.Label(text = "first column", backgroundColor = Color.Yellow).Row(2).Column(0)
                                View.Label(text = "second column", backgroundColor = Color.Green).Row(2).Column(1)
                                View.Label(text = "column spanning", backgroundColor = Color.Orange).Row(3).ColumnSpan(2)
                            ]
                        )
                )
        }
        {   Name = "RelativeLayout"; 
            Page = 
                View.ContentPage(title ="RelativeLayout", content = 
                    View.RelativeLayout
                        ( children = [ 
                            View.Label(text = "RelativeLayout Example", textColor = Color.Red)
                                .XConstraint(Constraint.RelativeToParent(fun parent -> 0.0))
                            View.Label(text = "Positioned relative to my parent", textColor = Color.Red)
                                .XConstraint(Constraint.RelativeToParent(fun parent -> parent.Width / 3.0))
                                .YConstraint(Constraint.RelativeToParent(fun parent -> parent.Height / 2.0))
                        ] )
                )
        }
        {   Name = "AbsoluteLayout"; 
                   Page = 
                       View.ContentPage(title ="AbsoluteLayout", content = 
                           View.AbsoluteLayout
                               (   backgroundColor = Color.Blue.WithLuminosity(0.9),
                                   children = [
                                       View.Label(text = "Top Left", textColor = Color.Black)
                                           .LayoutFlags(AbsoluteLayoutFlags.PositionProportional)
                                           .LayoutBounds(Rectangle(0.0, 0.0, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize))
                                       View.Label(text = "Centered", textColor = Color.Black)
                                           .LayoutFlags(AbsoluteLayoutFlags.PositionProportional)
                                           .LayoutBounds(Rectangle(0.5, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize))
                                       View.Label(text = "Bottom Right", textColor = Color.Black)
                                           .LayoutFlags(AbsoluteLayoutFlags.PositionProportional)
                                           .LayoutBounds(Rectangle(1.0, 1.0, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize))
                                   ]
                           )
                       )
               }
        {   Name = "FlexLayout"; 
            Page = 
                View.ContentPage(title ="FlexLayout", content = 
                    View.FlexLayout
                        (   direction=FlexDirection.Column,
                            children = [
                                View.Label(text = "Seated Monkey", fontSize = FontSize.fromNamedSize NamedSize.Large, textColor=Color.Blue)
                                View.Label(text = "This monkey is laid back and relaxed.")
                                View.Label(text = "  - Often smiles mysteriously")
                                View.Label(text = "  - Sleeps sitting up")

                                View.Image(
                                    source = Image.ImagePath "images/160px-Vervet_monkey_Krugersdorp_game_reserve_%285657678441%29.jpg"
                                ).Order(-1).AlignSelf(FlexAlignSelf.Center)        
        
                                View.Label(margin = Thickness(0.0, 4.0)).Grow(1.0)
                                View.Button(text = "Learn More", fontSize = FontSize.fromNamedSize NamedSize.Large, cornerRadius = 20)
                            ]
                        )
                )
        }       
    ]    