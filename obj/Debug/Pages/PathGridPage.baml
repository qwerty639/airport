   M S B A M L   `   `   `  ����B  >AIRPORT, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:AIRPORT.PagesAIRPORT.Pages  5           AIRPORT.Pages.PathGridPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:AIRPORT.Pages     5      -   5          N� Title$  PathGridPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��0.4* �6   �� 5      $��* �6   �� 5      $
��0.4* �6   .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��* �6#   .+�5      �� $��0��6   $��Center=�5      $��Center=�5      .+�5      �� -   5        $��Добавить��5      $��30��5      $	��150��5      $��15(�5      6'   5       �� 5"      $��1��6    �� Orientation$ Vertical=�5#      $��Center=�5$      $��Center=�5%      .+�5&      �� -   5         ��Name$
 chk1��5'      $��Фильтр 1��5&      5'      �� 5(      -   5        $
 chk2��5)      $��Фильтр 1��5(      5)      �� 5*      -   5        $
 chk3��5+      $��Фильтр 1��5*      5+      �� 5,      -   5        $
 chk4��5-      $��Фильтр 1��5,      5-      5.      5/      � 51   
   $��1��6   .+�52      &   System.Windows.Controls.DataGrid  -   5          Name$ dbView��52         AutoGenerateColumns .     
IsReadOnly .    ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 55      $��10q�56      	   Columns	 58      0  *System.Windows.Controls.DataGridTextColumn  59      ,  &System.Windows.Controls.DataGridColumn
   Header$
 ID��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *ID+  5:      $
 Расстояние��6)    6=   �� *
DISTANCE+  5;      $
 Пункт вылета��6)    6?   �� *	DEPARTURE+  5<      $%
 Пункт назначения��6)    6C   �� *DESTINATION+5?      5@      � 5B   
   $��2��6   .+�5C      �� $ 
Horizontal=�6   $��Center=�5D      $��Center=�5E      .+�5F      �� -   5         ��Name$ btn_Edit��5F      $ ��РЕДАКТИРОВАТЬ��5G      $��	20 0 20 0q�5H      6,   �� 5J      -	   5        $ 
btn_Remove��5J      $��УДАЛИТЬ��5K      $��5q�5L      6$   �� 5O      -
   5        $ btn_Menu��5O      $��Главное меню��5P      60   5S      5T      5U      5V      