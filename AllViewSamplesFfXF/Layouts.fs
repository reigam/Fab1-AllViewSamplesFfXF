// Copyright Fabulous contributors. See LICENSE.md for license.
namespace AllViewSamplesFfXF

open Fabulous
open Fabulous.XamarinForms
open Xamarin.Forms
open Helpers

module SampleLayouts =
    let sampleLayouts (style: MyStyle) = [
        {   Name = "ContentView";  
            SampleType = "basic";
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
                                            text = "Label inside a ContentView"
                                        )
                            )
                )
        }
        {   Name = "Frame"; 
            SampleType = "basic";
            Page = 
                View.ContentPage(
                    backgroundColor = style.PageColor,
                    title ="Frame", 
                    content = 
                        View.Frame
                            ( 
                                horizontalOptions = style.Position,
                                verticalOptions = style.Position,
                                backgroundColor = style.LayoutColor,
                                padding = style.Padding,
                                hasShadow = true, 
                                borderColor = Color.Black,
                                content = 
                                    View.Label
                                        (
                                            horizontalOptions = style.Position,
                                            verticalOptions = style.Position,
                                            backgroundColor = style.ViewColor,
                                            padding = style.Padding,   
                                            text = "Label inside a Frame with Border"
                                        )
                            )      
                    )
        }
        {   Name = "ScrollView";
            SampleType = "basic";
            Page = 
                View.ContentPage(
                    backgroundColor = style.PageColor,
                    title ="ScrollView", 
                    content = 
                        View.ScrollView
                            ( 
                                horizontalOptions = style.Position,
                                verticalOptions = style.Position,
                                backgroundColor = style.LayoutColor,
                                padding = style.Padding,  
                                content = 
                                    View.StackLayout
                                        ( 
                                            children = [
                                                for i in 1 .. 30-> 
                                                    View.Label
                                                        (
                                                            horizontalOptions = style.Position,
                                                            verticalOptions = style.Position,
                                                            backgroundColor = style.ViewColor,
                                                            padding = style.Padding,
                                                            text = sprintf "Label as Child #%i inside a StackLayout inside a ScrollView" i
                                                        ) 
                                            ] 
                                        )
                            )   
                )
        }
        {   Name = "StackLayout"; 
            SampleType = "basic";
            Page = 
                View.ContentPage(
                    backgroundColor = style.PageColor,
                    title ="StackLayout", 
                    content = 
                        View.StackLayout
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
                                        text = "Label in a StackLayout"
                                    )
                                View.Button
                                    (
                                        horizontalOptions = style.Position,
                                        verticalOptions = style.Position,
                                        backgroundColor = style.ButtonColor,
                                        padding = style.Padding,    
                                        text = "Button in a StackLayout (no function)"                                        
                                    )
                                View.Label
                                    (
                                        horizontalOptions = style.Position,
                                        verticalOptions = style.Position,
                                        backgroundColor = style.ViewColor,
                                        padding = style.Padding,  
                                        text = "Label in a StackLayout"
                                    )
                            ] )   
                )
        }
        {   Name = "Grid"; 
            SampleType = "basic";
            Page = 
                View.ContentPage(
                    backgroundColor = style.PageColor,
                    title ="Grid", 
                    content = 
                        View.Grid
                            (
                                horizontalOptions = style.Position,
                                verticalOptions = style.Position,
                                backgroundColor = style.LayoutColor,
                                padding = style.Padding,  
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
                                    View.Label(
                                        backgroundColor = Color.LightBlue,
                                        padding = style.Padding,
                                        text = 
                                            "Label in a Grid: Row 0, Column 0 to 1 \nRow: Dimension.Auto"
                                        ).Row(0).ColumnSpan(2)                    
                                    View.Label(
                                        backgroundColor = Color.LightCoral,
                                        padding = style.Padding,
                                        text = 
                                            "Label in a Grid: Row 1, Column 0\nRows: Dimension.Auto\nColumn: Dimension.Absolute 200."
                                        ).Row(1).Column(0)
                                    View.Label(
                                        backgroundColor = Color.LightCyan,
                                        padding = style.Padding,
                                        text = 
                                            "Label in a Grid: Row 2, Column 0\nRows: Dimension.Absolute 150.\nColumn: Dimension.Absolute 200."
                                        ).Row(2).Column(0)
                                    View.Label(
                                        backgroundColor = Color.LightGreen,
                                        padding = style.Padding,
                                        text = 
                                            "Label in a Grid: Row 2, Column 1\nRows: Dimension.Auto\nColumn: Dimension.Star"
                                        ).Row(2).Column(1)
                                    View.Label(
                                        backgroundColor = Color.LightPink,
                                        padding = style.Padding,
                                        text = 
                                            "Label in a Grid: Row 3, Column 0 to 1\nRows: Dimension.Star"
                                        ).Row(3).ColumnSpan(2)
                                ]
                            )
                )
        }
        {   Name = "RelativeLayout"; 
            SampleType = "basic";
            Page = 
                View.ContentPage(
                    backgroundColor = style.PageColor,
                    title ="RelativeLayout", 
                    content = 
                        View.RelativeLayout
                            ( 
                                horizontalOptions = style.Position,
                                verticalOptions = style.Position,
                                backgroundColor = style.LayoutColor,
                                padding = style.Padding,  
                                children = [ 
                                    View.Label(
                                        horizontalOptions = style.Position,
                                        verticalOptions = style.Position,
                                        backgroundColor = style.ViewColor,
                                        padding = style.Padding,  
                                        text = "Label in a RelativeLayout"
                                    ).XConstraint(Constraint.RelativeToParent(fun parent -> 0.0))
                                    View.Label(
                                        horizontalOptions = style.Position,
                                        verticalOptions = style.Position,
                                        backgroundColor = style.ViewColor,
                                        padding = style.Padding,  
                                        text = "Label in a RelativeLayout"
                                    ).XConstraint(Constraint.RelativeToParent(fun parent -> parent.Width / 3.0))
                                     .YConstraint(Constraint.RelativeToParent(fun parent -> parent.Height / 2.0))
                                ] )
                )
        }
        {   Name = "AbsoluteLayout"; 
            SampleType = "basic";
            Page = 
                View.ContentPage(
                    backgroundColor = style.PageColor,
                    title ="AbsoluteLayout", content = 
                        View.AbsoluteLayout
                            (  
                                //horizontalOptions = style.Position,   ///this would break the Layout
                                //verticalOptions = style.Position,     ///this would break the Layout
                                backgroundColor = style.LayoutColor,
                                padding = style.Padding,  
                                children = [
                                    View.Label(
                                        horizontalOptions = style.Position,
                                        verticalOptions = style.Position,
                                        backgroundColor = style.ViewColor,
                                        padding = style.Padding,  
                                        text = "Label in an AbsoluteLayout\nPosition: Top Left"
                                    ).LayoutFlags(AbsoluteLayoutFlags.PositionProportional).LayoutBounds(Rectangle(0.0, 0.0, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize))
                                    View.Label(
                                        horizontalOptions = style.Position,
                                        verticalOptions = style.Position,
                                        backgroundColor = style.ViewColor,
                                        padding = style.Padding,  
                                        text = "Label in an AbsoluteLayout\nPosition: Centered"
                                    ).LayoutFlags(AbsoluteLayoutFlags.PositionProportional).LayoutBounds(Rectangle(0.5, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize))
                                    View.Label(
                                        horizontalOptions = style.Position,
                                        verticalOptions = style.Position,
                                        backgroundColor = style.ViewColor,
                                        padding = style.Padding,  
                                        text = "Label in an AbsoluteLayout\nPosition: Bottom Right"
                                    ).LayoutFlags(AbsoluteLayoutFlags.PositionProportional).LayoutBounds(Rectangle(1.0, 1.0, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize))
                                ]
                            )
                )
               }
        {   Name = "FlexLayout"; 
            SampleType = "basic";
            Page = 
                View.ContentPage(
                    backgroundColor = style.PageColor,
                    title ="FlexLayout", 
                    content = 
                        View.FlexLayout
                            (   
                                horizontalOptions = style.Position,
                                verticalOptions = style.Position,
                                backgroundColor = style.LayoutColor,
                                padding = style.Padding,  
                                direction=FlexDirection.Column,
                                children = [
                                    View.Label
                                        (
                                            horizontalOptions = style.Position,
                                            verticalOptions = style.Position,
                                            backgroundColor = style.ViewColor,
                                            padding = style.Padding,  
                                            text = ("Label in a FlexLayout\nFlexDirection Column")
                                        )
                                    View.Button
                                        (
                                            horizontalOptions = style.Position,
                                            verticalOptions = style.Position,
                                            backgroundColor = style.ButtonColor,
                                            padding = style.Padding,  
                                            text = ("Label in a FlexLayout\nFlexDirection Column\n(no fucntion)")
                                        )
                                    View.Label
                                        (
                                            horizontalOptions = style.Position,
                                            verticalOptions = style.Position,
                                            backgroundColor = style.ViewColor,
                                            padding = style.Padding,  
                                            text = ("Label in a FlexLayout\nFlexDirection Column")
                                        )
                                ]
                            )
                )
        }       
    ]    