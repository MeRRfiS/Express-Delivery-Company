   M S B A M L   `   `   `  ����K  GExpress Delivery, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Express_DeliveryExpress_Delivery  5   	   $    Express_Delivery.WatchEmployee   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Express_Delivery     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  Autorization��5	   	   $	��587��6   $	��960��6+    � WindowStyle$
 None=�67    � WindowStartupLocation$ CenterScreen=�6J   .��5
      � ���#28527A.+�5   
   �� $��Image/Menu.png��6   $	��Top=�6(   $��Center=�6@   $��2��6]   $��	0,0,0.6,0q�6q    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 4Q�6#      	Direction$	 270Q�62      Opacity$
 0.25Q�6B   5      �� 5   
   $��Працівники��6   $��54(�6&   $��Roboto)�64   $��DemiBold"�6H   $��39,12,339.6,498.8q�6^   �� 5   
   -   5        $	��←��5      $��Global User Interface)�6   $��788,10,104.6,510.8q�6@   ���	#FF626262���	#FF323232
���   �$��44(�6�   $��Normal"�6�   $
��Auto��6�   $��0q�6�    5        5      $ 9Q�6#   5      �� 5   
   -   5        $��×��5      $��Global User Interface)�6   $��859,10,34.6,510.8q�6@   
���  �����	#FF850000
���   �$��44(�6�   $��Normal"�6�   $
��Auto��6�   $��0q�6�    5        5      $ 9Q�6#   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGridEmployee��5      $
��Left=�6E   $	��468��6`   $��
39,103,0,0q�6m   $	��Top=�6�   $	��648��6�    � Cursor$ Arrow��6�   	 J� RenderTransformOrigin$	 0.5,0.5&�6�   
   
IsReadOnly
 . $
��Auto=�6�   $
��Auto=�6     AutoGenerateColumns .  ��6-   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   CanUserSort .     Header$ Ім'я��6a   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *employee_first_name+6a     5       .  $ Прізвище��6`    6%   �� *employee_last_name+6`     5       .  $% Номер відділення��6^    6%   �� *departmentNumber+6^     5        .  $ Посада��6V    6%   �� *
postName+6V     5!       .  $ Телефон��6Z    6%   �� *employee_tel+6Z   5#      �� 5$   
   $��692,103,34.6,9.8q�6   .+�5%      �� -   5         ��Name$ textBoxName��5%      $��Center=�6+   $	��227��6H   $��26��6T   
����������	#FF8AC4D0)  #MaterialDesignThemes.Wpf.HintAssist   Hint$" Ім'я працівника��6�   $
��22.5(�6�   $��8,0,0,0q�6�   $��Roboto)�6�      MaterialDesignTextBox#��[  6�   �� 5&      -   5        $ textBoxSurname��5&      $��0 15 0 0q�6.   $��Center=�6@   $	��227��6]   $��26��6i   
����������	#FF8AC4D0$  Пр. працівника��6�   $
��22.5(�6�   $��8,0,0,0q�6�   $��Roboto)�6�   #��[  6  �� 5'      -   5        $ textBoxPost��5'      $��0 15 0 0q�6+   $��Center=�6=   $	��227��6Z   $��26��6f   
����������	#FF8AC4D0$ Посада��6�   $
��22.5(�6�   $��8,0,0,0q�6�   $��Roboto)�6�   #��[  6�   �� 5(      -   5        $��0,15,0,0q�5(      $��Знайти��6'   $��Center=�68   ���	#FFF4D160
���   ����	#FFFBEEAC$��21(�6�   $��Roboto)�6�   $��3q�6�   $
��Auto��6�   $	��227��6�   �� 5)      -   5         ��Name$ 
buttonSave��5)      $��0,15,0,0q�6)   $��Зберегти��6;   $��Center=�6N   ���	#FFF4D160
���   ����	#FFFBEEAC$��21(�6�   $��Roboto)�6�   $��3q�6�   $
��Auto��6�   $	��227��6  $y�	Collapsed=�6  �� 5*      -	   5        $ 
buttonEdit��5*      $��0,15,0,0q�6)   $��Редагувати��6;   $��Center=�6P   ���	#FFF4D160
���   ����	#FFFBEEAC$��21(�6�   $��Roboto)�6�   $��3q�6�   $
��Auto��6�   $	��227��6  5+      5,      5-      