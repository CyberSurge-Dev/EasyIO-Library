## Get EasyIO on NuGet!

```
Install-Package EasyIO.Library -Version 1.1.1
```

EasyIO Library is a work in progress library designed to remake complex functions to be easier to use and understand.

#### A few things being worked on are:
- Rnd Class
- Converter Class
- Files Class Over time I plan to dissolve the IO class into simpler components, and add more useful components to the Math Class.

#### in the future i plan to add:
- A way to get information from images
- A easier way to format a string
- Extra functions for making Console App UI's
- Optimize code

#### Currently working on:
- Finishing Converter class
- Starting/Finishing Rnd Class
- Learning more about programming to expand into more advanced topics

Any recommendations for past code, or suggestions for future code are greatly appreciated.


## EasyIO overview:


  #### Converter Class
  - Allows conversion of arrays between 5 data types (Double, Int32, Long, String, Char)
  - Allows conversion of lists between 5 data types (Double, Int32, Long, String, Char) - 
  - Allows conversion of multidimensional arrays between 5 data types (Double, Int32, Long, String, Char)
  - Allows conversion of multidimensional lists between 5 data types (Double, Int32, Long, String, Char) 
  -  Conversion between lists and arrays
  - Conversion between multidimensional lists, and arrays
    
    NOTE: working on a way to have an adaptable multidimensional array and list parameters to suit a wider variety of inputs.

    To be added:
    - ways to convert to binary 
    - convert to certain string formats

  #### Files Class
  - Read Specific lines of files.
  - Write to specific lines of files.
  - Append a line to a file.
  - Read all lines in the file.
  - Clear Files
  - Zip Files
  - Search Files
  - Create Files
    
  To be added:
  - A way to add multiple lines to file
	- A way to create lists from files
  - Insert lines into file
  - format lines

  #### IO Class
  - wide variety of random functions, usually to ease the creation of UI's for console apps
  - contains many older functions that are being updated or removed. 
    notable mentions:
    - dynamic Table function
    - lisst function
    - ackets function
    - textxt color function
    - background color function
    - brackets function
    - many more. 
      
      NOTE: I plan to dissolve this class into small classes for ease of use.

  #### Math Class: 
  - Contains basic math functions Notable Mentions: 
  - Mean 
  - Median 
  - Mode 
  - Add 
  - Subtract 
  - Multiply 
  - Divide 

	To be added:
    - Trig 
    - Area  
    - Eventually some form of function handler 
    - and more

  #### Rnd Class: 
  - This class is for getting randomly generated items in the form of arrays, and lists.
  - get multiple different data types
  - get arrays, and lists of varying sizes 
    
    NOTE: Currently no functions are in the Rnd Class, but they are being worked on


EasyIO is still very much a work in progress, if you have any questions, suggestions, or concerns about this library feel free to let me know. I have big plans to continue to work on this project and eventually create something useful that is not limited to basic functions. I will be sure to keep this updated as often as i can, but sometimes work may fall ahead of documentation.
There will be an example file out soon to demonstrate EasyIO and its functions.