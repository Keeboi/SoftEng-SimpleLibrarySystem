   M S B A M L   `   `   `  ����B  >Library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:LibraryLibrary  5          Library.UserControl_Books   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:Library     5      
�������$	��550��5   J   $	��875��6Z   .��5	      �   � RowDefinitions  5
   
   �� 5      �� 5      $��10 �6    � ColumnDefinitions 5   
   �� 5      $	��230 �6   �� 5      .+�5   
   �� $��Title��6   $
��Left=�6    $��	35,10,0,0q�6;   $	��Top=�6N   $��26��6f   $��32��6r   �� 5   
   -   5         ��Name$ 	textTitle��5      $
��Left=�6%   $��26��6@   $��	72,10,0,0q�6L    �� TextWrapping$
 Wrap=�6_   $	��Top=�6s   $	��150��6�   $��Center=�6�   �� 5   
   $��Book ID��6   $
��Left=�6"   $��	15,41,0,0q�6=   $	��Top=�6P   $��26��6h   $��52��6t   �� 5   
   -   5        $ 
textBookID��5      $
��Left=�6&   $��26��6A   $��	72,41,0,0q�6M   $
 Wrap=�6`   $	��Top=�6t   $	��150��6�   $��Center=�6�   �� 5   
   $��Author��6   $
��Left=�6!   $��	20,72,0,0q�6<   $	��Top=�6O   $��26��6g   $��47��6s   �� 5   
   $
��Year��6   $
��Left=�6   $��
35,103,0,0q�6:   $	��Top=�6N   $��26��6f   $��32��6r   �� 5   
   -   5        $ textYear��5      $
��Left=�6$   $��26��6?   $��
72,103,0,0q�6K   $
 Wrap=�6_   $	��Top=�6s   $	��150��6�   $��Center=�6�   �� 5   
   $��Quantity��6   $
��Left=�6#   $��
11,134,0,0q�6>   $	��Top=�6R   $��26��6j   $��56��6v   �� 5   
   -   5        $ textQuantity��5      $
��Left=�6(   $��26��6C   $��
72,134,0,0q�6O   $
 Wrap=�6c   $	��Top=�6w   $	��150��6�   $��Center=�6�   �� 5   
   $��Pages��6   $
��Left=�6    $��
26,165,0,0q�6;   $	��Top=�6O   $��26��6g   $��41��6s   �� 5   
   -   5        $ 	textPages��5      $
��Left=�6%   $��26��6@   $��
72,165,0,0q�6L   $
 Wrap=�6`   $	��Top=�6t   $	��150��6�   $��Center=�6�   �� 5   
   -   5         ��Name$ comboAuthor��5      $
��Left=�6(   $��	72,72,0,0q�6C   $	��Top=�6V   $	��150��6n   $��26��6z    �� 
IsEditable . $��Center=�6�   �� 5   
   $��Category��6   $
��Left=�6#   $��	9,196,0,0q�6>   $	��Top=�6Q   $��26��6i   $��58��6u   �� 5   
   -   5        $ comboCategory��5      $
��Left=�6*   $��
72,196,0,0q�6E   $	��Top=�6Y   $	��150��6q   $��26��6}    . $��Center=�6�   �� 5    
   $��Section��6   $
��Left=�6"   $��
18,227,0,0q�6=   $	��Top=�6Q   $��26��6i   $��49��6u   �� 5!   
   -   5        $ comboSection��5!      $
��Left=�6)   $��
72,227,0,0q�6D   $	��Top=�6X   $	��150��6p   $��26��6|    . $��Center=�6�   �� 5"   
   $��Comments��6   $
��Left=�6#   $��	0,258,0,0q�6>   $	��Top=�6Q    J� RenderTransformOrigin$ 0.373,0.423&�6i   $��26��6�   $��67��6�   �� 5#   
   -	   5        $ textComments��5#      $
��Left=�6(   $	��100��6C   $��
72,258,0,0q�6P   $
 Wrap=�6d   $	��Top=�6x   $	��150��6�   &   System.Windows.Controls.DataGrid  5$   
   -
   5          Name$ dg��5$      $��10q�6   $��1��6+      AutoGenerateColumns . 	   CanUserSortColumns	 . 
   CanUserAddRows
 .     CanUserDeleteRows .     CanUserResizeColumns .     CanUserResizeRows .     CanUserReorderColumns .     EnableRowVirtualization .     HeadersVisibility$ Column=�6F     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6a     
IsReadOnly . ��6V   ��  �� Path$ books� �� Mode$ OneWay=�6�  �� 5%   
   -   5         ��Name$ buttonSearchAdd��5%      $��Search / Add��6*   $
��Left=�6A   $��
72,363,0,0q�6\   $	��Top=�6p   $	��150��6�   $��20��6�   6�   �� 5&   
   -   5        $ buttonClear��5&      $��Clear��6&   $
��Left=�66   $��
72,388,0,0q�6Q   $	��Top=�6e   $	��150��6}   $��20��6�   6�   5'      5(      