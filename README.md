# Showcasing blurred text with Xamarin.Forms on MacOS

The project contains minimal code to show that (in some conditions), Labels are renders blurry **on non-retina displays**.

Zooming in makes the problem more visible:

| Blurred                                 | Sharp                              |
| --------------------------------------- | ---------------------------------- |
| ![blurred](zoomed_blurry.png "Blurred") | ![sharp](zoomed_sharp.png "Sharp") |

In [blurredText/blurredTextPage.xaml](blurredText/blurredTextPage.xaml), there are some Labels defined with different HorizontalOptions set.

This is a screenshot on a non-retina display, wheras the first 6 labels are blurred and the last 3 are sharp:
![screenshot](screenshot.png "Screenshot")
