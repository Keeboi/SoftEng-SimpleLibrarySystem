   M S B A M L   `   `   `  ����B  >Library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:LibraryLibrary  5   	       Library.Window_AddStudent   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Library     5   	     � Title$  Add Student��5   	   $��233.203��6   $	��280��6.    � 
ResizeMode$ NoResize=�6:    � ShowInTaskbar .  .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��49* �6   �� 5      $	��88* �6   .+�5   
   �� $��
Student ID��6   $
��Left=�6%   $��26,7,0,0q�6@   $	��Top=�6R   $��26��6j   $��66��6v   �� 5   
   $��Grade Section��6   $
��Left=�6(   $	��Top=�6C   $��
10,102,0,0q�6[   $��26��6o   $��88��6{   �� 5   
   $��	Last Name��6   $
��Left=�6$   $	��Top=�6?   $��	26,69,0,0q�6W   $��26��6j   $��66��6v   �� 5   
   $��
First Name��6   $
��Left=�6%   $	��Top=�6@   $��	25,38,0,0q�6X   $��26��6k   $��67��6w   �� 5   
   -   5         ��Name$ textLastName��5      $
��Left=�6(   $��23��6C    �� TextWrapping$
 Wrap=�6O   $	��Top=�6c   $	��155��6{   $��4,73,0,0q�6�   $��1��6�   �� 5   
   -   5        $ textFirstName��5      $
��Left=�6)   $��23��6D   $
 Wrap=�6P   $	��Top=�6d   $	��155��6|   $��4,42,0,0q�6�   $��1��6�   �� 5   
   -   5        $ textStudentID��5      $
��Left=�6)   $��23��6D   $
 Wrap=�6P   $	��Top=�6d   $	��155��6|   $��4,10,0,0q�6�   $��1��6�   �� 5   
   -   5         ��Name$ comboSection��5      $
��Left=�6)   $��	4,106,0,0q�6D   $	��Top=�6W   $	��155��6o   $��1��6{   $��22��6�   �� 5   
   -   5         ��Name$ buttonClear��5      $��Clear��6&   $
��Left=�66   $	��Top=�6Q   $	��155��6i   $��	4,158,0,0q�6u   $��1��6�   $��20��6�   �� 5   
   -   5        $ 	buttonAdd��5      $	��Add��6$   $
��Left=�62   $	��Top=�6M   $	��155��6e   $��	4,133,0,0q�6q   $��1��6�   $��20��6�   5      5      