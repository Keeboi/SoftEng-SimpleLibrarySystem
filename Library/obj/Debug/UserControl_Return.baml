   M S B A M L   `   `   `  ����B  >Library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:LibraryLibrary  5           Library.UserControl_Return   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:Library     5      
�������$	��550��5   J   $	��875��6Z   .��5	      �   � ColumnDefinitions  5
   
   �� 5      $	��230 �6   �� 5      .+�5   
   �� $��Book ID��6   $
��Left=�6"   $��	29,10,0,0q�6=   $	��Top=�6P   $��26��6h   $��52��6t   �� 5   
   -   5         ��Name$ 
textBookID��5      $
��Left=�6&   $��26��6A   $��	86,10,0,0q�6M    �� TextWrapping$
 Wrap=�6`   $	��Top=�6t   $	��134��6�   $��Center=�6�   �� 5   
   $��
Student ID��6   $
��Left=�6%   $��	15,41,0,0q�6@   $	��Top=�6S   $��26��6k   $��66��6w   �� 5   
   -   5        $ textStudentID��5      $
��Left=�6)   $��26��6D   $��	86,41,0,0q�6P   $
 Wrap=�6c   $	��Top=�6w   $	��134��6�   $��Center=�6�   �� 5   
   -   5         ��Name$ buttonSearch��5      $��Search��6'   $
��Left=�68   $��	86,72,0,0q�6S   $	��Top=�6f   $	��134��6~   6�   �� 5   
   -   5        $ buttonClear��5      $��Clear��6&   $
��Left=�66   $��
86,122,0,0q�6Q   $	��Top=�6e   $	��134��6}   6�   �� 5   
   -   5        $ buttonReturn��5      $��Return��6'   $
��Left=�68   $��	86,97,0,0q�6S   $	��Top=�6f   $	��134��6~   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dg��5      $��10q�6   $��1��6+      AutoGenerateColumns .    CanUserSortColumns .    CanUserAddRows .     CanUserDeleteRows .  	   CanUserResizeColumns	 .  
   CanUserResizeRows
 .     CanUserReorderColumns .     EnableRowVirtualization .     HeadersVisibility$ Column=�6I     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6d     
IsReadOnly . ��6V   ��  �� Path$ returned� �� Mode$ OneWay=�6�  5      5      