# Image Processing Project

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Windows Forms](https://img.shields.io/badge/Windows%20Forms-0078D6?style=for-the-badge&logo=windows&logoColor=white)
![Krypton Toolkit](https://img.shields.io/badge/Krypton%20Toolkit-6B4FBB?style=for-the-badge)
![Git](https://img.shields.io/badge/Git-F05032?style=for-the-badge&logo=git&logoColor=white)
![GitHub](https://img.shields.io/badge/GitHub-181717?style=for-the-badge&logo=github&logoColor=white)

## 1. Project Overview

This is an image processing and editing application developed using C#. The project contains 15 different image processing operations. These operations were implemented manually without relying on ready-made libraries to perform the image processing tasks. Instead, the project works directly with image data and pixels and applies the required algorithms.

---

## 2. Project Purpose

The purpose of this project is to understand how images can be handled at the pixel level and how image processing operations can be implemented manually without relying on ready-made libraries. This was achieved by building custom functions and algorithms and applying them directly to image data for different processing, transformation, and editing operations.

---

## 3. Key Features

* 15 different image processing operations, with each operation available independently through its dedicated screen.
* Sequential processing of the same image through the `Çoklu İşlemler` feature, which allows a selected group of operations to be applied one after another.
* Preserving the original image and displaying processed results in separate areas without modifying the original image.
* Ability to undo modifications when needed.
* Ability to save processed results.
* Ability to save individual results separately in most operations.
* MDI-based interface organization to facilitate navigation between image processing screens.

---

## 4. Screenshots

The following screenshots showcase a selected set of the project's image processing operations and features, highlighting the variety of functionality provided by the application.

### Morphological Operations

![Morphological Operations](Görüntü%20işleme/images/Morphological_Operations.png)

### Histogram Operations

![Histogram Operations](Görüntü%20işleme/images/Histogram_Operations.png)

### Noise Addition & Cleaning

![Noise Addition & Cleaning](Görüntü%20işleme/images/Noise_Addition_Cleaning.png)

### Arithmetic Operations

![Arithmetic Operations](Görüntü%20işleme/images/Arithmetic_Operations.png)

### Edge Detection

![Edge Detection](Görüntü%20işleme/images/Edge_Detection.png)

### Color Space Conversions

![Color Space Conversions](Görüntü%20işleme/images/Color_Space_Conversions.png)

### Image Rotation

![Image Rotation](Görüntü%20işleme/images/Image_Rotation.png)

### Grayscale Conversion

![Grayscale Conversion](Görüntü%20işleme/images/Grayscale_Conversion.png)

### Binary Conversion

![Binary Conversion](Görüntü%20işleme/images/Binary_Conversion.png)

### Image Cropping

![Image Cropping](Görüntü%20işleme/images/Image_Cropping.png)

### Contrast Enhancement

![Contrast Enhancement](Görüntü%20işleme/images/Contrast_Enhancement.png)

### Multiple Operations

This screen demonstrates applying multiple operations sequentially to the same image: rotating the image clockwise, converting it to grayscale, and then reducing its size.

![Multiple Operations](Görüntü%20işleme/images/Multiple_Operations.png)

---

## 5. Image Processing Operations

1. **Morfolojik İşlemler**
   Applying different morphological operations to process shapes and regions within an image.

2. **Gürültü Ekleme - Temizleme**
   Adding different types of noise to an image and applying operations to clean the image and reduce the effect of noise.

3. **Aritmetik İşlemler**
   Performing arithmetic operations on images, such as adding two images and dividing images.

4. **Görüntü Kırpma**
   Selecting a specific region of an image and cropping and displaying the selected area.

5. **Görüntü Döndürme**
   Rotating an image clockwise or counterclockwise by a user-defined angle, such as 30°, 45°, 90°, or other values.

6. **Histogram İşlemleri**
   Performing different operations using histograms to analyze and modify the distribution of image values.

7. **Gri Dönüşüm**
   Converting a color image into a grayscale image.

8. **Binary Dönüşüm**
   Converting an image into a binary image based on two possible values.

9. **Kontrast Artırma**
   Increasing the contrast between different colors and intensity values in an image.

10. **Eşikleme İşlemleri**
    Applying thresholding operations to an image based on a defined threshold value.

11. **Konvolüsyon İşlemi**
    Applying convolution operations to an image using matrices or filters to process pixel values.

12. **Görüntü Yaklaştırma/Uzaklaştırma**
    Increasing or decreasing the size of an image by changing its dimensions.

13. **Kenar Bulma**
    Detecting edges and significant changes in pixel values within an image.

14. **Filtre Uygulaması**
    Applying different types of filters to process specific characteristics of an image.

15. **Renk Uzayı Dönüşümleri**
    Converting an image between different color spaces.

---

## 6. Project Structure

The project is organized into two main folders:

* **Functions:** Contains the classes and functions responsible for image processing operations. A separate class is used for each operation to organize the code, facilitate maintenance and development, and allow functions to be reused when needed.
* **Screens:** Contains the classes responsible for the application's interfaces and screens, with each screen handling its related operation or functionality.

---

## 7. Technologies & Tools

* **C#**
* **Windows Forms**
* **.NET / .NET Framework**
* **Krypton Toolkit**
* **Git & GitHub**

---

## 8. What This Project Demonstrates

1. **C# Programming** — Building the project and implementing the operations using C#.
2. **Image Processing** — Working directly with image data and pixels and implementing image processing algorithms.
3. **Algorithm Implementation** — Building and implementing operations instead of relying on ready-made libraries to perform them.
4. **Object-Oriented Programming (OOP)** — Organizing operations and screens using classes.
5. **Code Organization & Maintainability** — Separating `Functions` and `Screens` and using a separate class for each operation.
6. **Windows Forms Development** — Building the application interface and organizing its screens.
7. **Problem Solving** — Working with different image processing operations to achieve the required results.

---

## 9. Future Improvements

* Improve and expand the **Çoklu İşlemler** screen by adding new options and capabilities for controlling the sequence of image processing operations.
* Expand the operations that can be used within **Çoklu İşlemler** so that more of the available image processing operations can be combined.
* Add new features and options to improve the user experience and expand the image processing and editing capabilities.
  * Continue developing the project by adding new processing operations and improving existing functionality.