   M S B A M L   `   `   `  ����K  GExpress Delivery, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Express_DeliveryExpress_Delivery  5   	   !    Express_Delivery.WatchOrder   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Express_Delivery     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  Autorization��5	   	   $	��587��6   $	��960��6+    � WindowStyle$
 None=�67    � WindowStartupLocation$ CenterScreen=�6J   .��5
      � ���#28527A.+�5   
   �� $��Image/Menu.png��6   $	��Top=�6(   $��	0,0,0.6,0q�6@    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 4Q�6#      	Direction$	 270Q�62      Opacity$
 0.25Q�6B   5      �� 5   
   $��Замовлення��6   $��54(�6&   $��Roboto)�64   $��DemiBold"�6H   $��39,12,339.6,498.8q�6^   �� 5   
   -   5        $	��←��5      $��Global User Interface)�6   $��788,10,104.6,510.8q�6@   ���	#FF626262���	#FF323232
���   �$��44(�6�   $��Normal"�6�   $
��Auto��6�   $��0q�6�    5        5      $ 9Q�6#   5      �� 5   
   -   5        $��×��5      $��Global User Interface)�6   $��859,10,34.6,510.8q�6@   
���  �����	#FF850000
���   �$��44(�6�   $��Normal"�6�   $
��Auto��6�   $��0q�6�    5        5      $ 9Q�6#   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGridOrderMin��5      $
��Left=�6E   $	��414��6`   $��
39,103,0,0q�6m   $	��Top=�6�   $	��475��6�    � Cursor$ Arrow��6�   	 J� RenderTransformOrigin$	 0.5,0.5&�6�   
   
IsReadOnly
 . $
��Auto=�6�   $
��Auto=�6     AutoGenerateColumns .  $��14(�6�  ��6-   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   CanUserSort .     Header$! ПІБ Отримувача��6b   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *order_name_recipient+6b     5       .  $# Дата оформлення��6W    6%   �� *	dateOrder+6W     5       .  $% Номер відділення��6e    6%   �� *order_department_number+6e   5!        5"   
   -   5        $ dataGridOrder��5"      $
��Left=�6B   $	��414��6]   $��519,103,0,0q�6j   $	��Top=�6   $	��400��6�   $ Arrow��6�   $	 0.5,0.5&�6�   
 . $
��Auto=�6�   $
��Auto=�6   .     GridLinesVisibility$ 
Horizontal=�6b  $��14(�6�  ��6*   ��  5#        5$       .  $ 
Назва��6R    6%   �� *Name+6R     5%       .  $ Інформація��6Y    6%   �� *Information+6Y   5'      �� 5(   
   -   5         ��Name$ 	textBoxID��5(      $��Center=�6%   $	��227��6B   
����������	#FF8AC4D0)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ ID замовлення��6y   $
��22.5(�6�   $��8,0,0,0q�6�   $��Roboto)�6�      MaterialDesignTextBox#��[  6�   $��39,534,687.6,16.8q�6  �� 5)   
   -   5        $��271,531,455.6,12.8q�5)      $��Знайти��6-   $��Center=�6>   ���	#FFF4D160
���   ����	#FFFBEEAC$��21(�6�   $��Roboto)�6�   $��3q�6�   $
��Auto��6�   $	��227��6�   �� 5*   
   -   5         ��Name$ 
buttonEdit��5*      $��503,531,223.6,12.8q�6%   $��Редагувати��6A   $��Center=�6V   ���	#FFF4D160
���   ����	#FFFBEEAC$��21(�6�   $��Roboto)�6�   $��3q�6�   $
��Auto��6�   $	��227��6  $y�	Collapsed=�6  � 5+   
   -   5         �Name$ gridEdit��5+      ���	#66000000$y�	Collapsed=�68   .+�5,        -	   5        $ dataGridEdit��5,      $��
74,229,0,0q�6-   $
��Left=�6Y   $	��139��6t   $	��Top=�6�   $	��796��6�   $ Arrow��6�   $	 0.5,0.5&�6�   $
��Auto=�6�   $
��Auto=�6  $ 
Horizontal=�66   .  ��6A   ��  5-        5.       .  $! Дата отримання��6_    6)   �� *dateReceiving+6_     5/       .  $# Дата зберірання��6Y    6)   �� *	dateEnd+6Y     50       .  $ Крихкість��6a    6)   �� *order_fragility+6a     51       .  $' !Зворот документів��6^    6)   �� *order_return+6^     52       .  $&  Місцезнаходження��6]    6)   �� *order_place+6]     53       .  $! ПІБ отримувача��6f    6)   �� *order_name_recipient+6f     54       .  $) #Телефон отримувача��6e    6)   �� *order_tel_recipient+6e     55       .  $% Номер відділення��6i    6)   �� *order_department_number+6i   57      �� 58      -
   5        $ 
buttonSave��58      $��643,373,83.6,161.8q�6)   $��Зберегти��6E   $��Center=�6X   ���	#FFF4D160
���   ����	#FFFBEEAC$��21(�6�   $��Roboto)�6�   $��3q�6�   $
��Auto��6�   $	��227��6  59      5:      5;      