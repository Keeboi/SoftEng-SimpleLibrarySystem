   M S B A M L   `   `   `  ����B  >Library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:LibraryLibrary  5   	       Library.Window_Login   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Library     5   	     � Title$  Window_Login��5   	   $	��140��6   $	��300��6+    � WindowStartupLocation$ CenterScreen=�67    � 
ResizeMode$ NoResize=�6\   .��5	      �  � RowDefinitions 5
   
   �� 5       � ColumnDefinitions 5   
   �� 5      $	��294 �6   .+�5   
   �� $��Username��6   $
��Left=�6#   $��	10,10,0,0q�6>   $	��Top=�6Q   $��26��6i   $��63��6u   �� 5   
   $��Password��6   $
��Left=�6#   $��	13,41,0,0q�6>   $	��Top=�6Q   $��26��6i   $��60��6u   �� 5   
   -   5         ��Name$ textUsername��5      $
��Left=�6(   $��26��6C   $��	78,10,0,0q�6O    �� TextWrapping$
 Wrap=�6b   $��admin��6v   $	��Top=�6�   $	��194��6�   $��Center=�6�   $��Center=�6�   G� 5   
   -   5         G�Name$ textPassword��5      $
��Left=�6,   $��	78,41,0,0q�6G   $	��Top=�6Z   $	��194��6r   $��26��6~   $��Center=�6�   $��Center=�6�    G� Password$ admin��6�   �� 5   
   -   5        	 ��Name$	 buttonLogin��5      $��Login��6&   $
��Left=�66   $��
179,72,0,0q�6Q   $	��Top=�6e   $��93��6}   6�   �� 5   
   -   5        $	 buttonClear��5      $��Clear��6&   $
��Left=�66   $��	78,72,0,0q�6Q   $	��Top=�6d   $��96��6|   6�   5      5      