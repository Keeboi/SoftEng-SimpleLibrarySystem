   M S B A M L   `   `   `  ����B  >Library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:LibraryLibrary  5   	       Library.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Library     5   	     � Title$,  &Sto. Rosario Library Management System��5   	   $	��600��68   $
��1024��6E    � WindowStartupLocation$ CenterScreen=�6R   $	��600��6w   $
��1024��6�   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��120 �6   �� 5      �� 5      $��10 �6    � RowDefinitions 5   
   �� 5      �� 5      $��10 �6   .+�5   
   �� -   5         ��Name$ buttonBooks��5      $��Books��6&   $
��Left=�66   $��	10,10,0,0q�6Q   $	��Top=�6d   $��16(�6|   $��Light"�6�   $��50��6�   $	��100��6�   6�   �� 5   
   -   5        $ buttonBorrow��5      $��Borrow��6'   $
��Left=�68   $��	10,65,0,0q�6S   $	��Top=�6f   $��16(�6~   $��Light"�6�   $��50��6�   $	��100��6�   6�   �� 5   
   -   5        $ buttonReturn��5      $��Return��6'   $
��Left=�68   $��
10,120,0,0q�6S   $	��Top=�6g   $��16(�6   $��Light"�6�   $��50��6�   $	��100��6�   6�   �� 5   
   -   5        $ buttonLogout��5      $��Logout��6'   $��	10,0,0,10q�68   $��16(�6K   $��Light"�6Y   $��50��6l   $��Bottom=�6x   $
��Left=�6�   $	��100��6�   6�   �� 5   
   -   5        $ buttonStudents��5      $��Students��6)   $
��Left=�6<   $��
10,175,0,0q�6W   $	��Top=�6k   $��16(�6�   $��Light"�6�   $��50��6�   $	��100��6�   6�   �� 5   
   -   5        $ buttonAccounts��5      $��Accounts��6)   $
��Left=�6<   $��
10,230,0,0q�6W   $	��Top=�6k   $��16(�6�   $��Light"�6�   $��50��6�   $	��100��6�   6�   �� 5   
   -   5         ��Name$ 
stackPanel��5      $��1��6)   $��	10,10,0,0q�69   5      5      