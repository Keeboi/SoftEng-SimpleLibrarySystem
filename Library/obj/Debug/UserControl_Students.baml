   M S B A M L   `   `   `  ����B  >Library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:LibraryLibrary  5      "    Library.UserControl_Students   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:Library     5      
�������$	��550��5   J   $	��875��6Z   .��5	      �   � ColumnDefinitions  5
   
   �� 5      $	��260 �6   �� 5      .+�5   
   �� $��
Student ID��6   $
��Left=�6%   $��	26,10,0,0q�6@   $	��Top=�6S   $��26��6k   $��66��6w   $��Center=�6�   $��Center=�6�   �� 5   
   -   5         ��Name$ textStudentID��5      $
��Left=�6)   $��26��6D   $��	97,10,0,0q�6P    �� TextWrapping$
 Wrap=�6c   $	��Top=�6w   $	��150��6�   $��Center=�6�   �� 5   
   $��
First Name��6   $
��Left=�6%   $��	25,41,0,0q�6@   $	��Top=�6S   $��26��6k   $��67��6w   $��Center=�6�   $��Center=�6�   �� 5   
   -   5        $ textFirstName��5      $
��Left=�6)   $��26��6D   $��	97,41,0,0q�6P   $
 Wrap=�6c   $	��Top=�6w   $	��150��6�   $��Center=�6�   �� 5   
   $��	Last Name��6   $
��Left=�6$   $��	26,72,0,0q�6?   $	��Top=�6R   $��26��6j   $��66��6v   $��Center=�6�   $��Center=�6�   �� 5   
   -   5        $ textLastName��5      $
��Left=�6(   $��26��6C   $��	97,72,0,0q�6O   $
 Wrap=�6b   $	��Top=�6v   $	��150��6�   $��Center=�6�   �� 5   
   $��Middle Name��6   $
��Left=�6&   $��
10,103,0,0q�6A   $	��Top=�6U   $��26��6m   $��82��6y   $��Center=�6�   $��Center=�6�   �� 5   
   -   5        $ textMiddleName��5      $
��Left=�6*   $��26��6E   $��
97,103,0,0q�6Q   $
 Wrap=�6e   $	��Top=�6y   $	��150��6�   $��Center=�6�   �� 5   
   $��Grade Level��6   $
��Left=�6&   $��
20,134,0,0q�6A   $	��Top=�6U   $��26��6m   $��72��6y   $��Center=�6�   $��Center=�6�   �� 5   
   -   5         ��Name$ 
comboGrade��5      $
��Left=�6'   $��
97,134,0,0q�6B   $	��Top=�6V   $	��150��6n   $��26��6z   �� 5   
   -   5         ��Name$ buttonSearchAdd��5      $��Search / Add��6*   $
��Left=�6A   $��
97,165,0,0q�6\   $	��Top=�6p   $	��150��6�   $��20��6�   6�   �� 5   
   -   5        $ buttonClear��5      $��Clear��6&   $
��Left=�66   $��
97,190,0,0q�6Q   $	��Top=�6e   $	��150��6}   $��20��6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dg��5      $��10q�6   $��1��6+      AutoGenerateColumns .    CanUserSortColumns .    CanUserAddRows .  	   CanUserDeleteRows	 .  
   CanUserResizeColumns
 .     CanUserResizeRows .     CanUserReorderColumns .     EnableRowVirtualization .     HeadersVisibility$ Column=�6I     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6d     
IsReadOnly . ��6V   ��  �� Path$ students� �� Mode$ OneWay=�6�  5      5      