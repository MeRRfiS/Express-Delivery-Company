   M S B A M L   `   `   `  ����K  GExpress Delivery, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Express_DeliveryExpress_Delivery  5   	   "    Express_Delivery.NewEmployee   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Express_Delivery     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  Autorization��5	   	   $	��587��6   $	��960��6+    � WindowStyle$
 None=�67    � WindowStartupLocation$ CenterScreen=�6J   .��5
      � ���#28527A.+�5   
   �� $��Image/Menu.png��6   $	��Top=�6(   $��Center=�6@   $��2��6]   $��	0,0,0.6,0q�6q    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 4Q�6#      	Direction$	 270Q�62      Opacity$
 0.25Q�6B   5      �� 5   
   $3��-Зареєструвати робітника��6   $��46(�63   $��Roboto)�6A   $��DemiBold"�6U   $��39,14,339.6,508.8q�6k    J� RenderTransformOrigin$ 0.496,0.793&�6�   �� 5   
   -   5        $	��←��5      $��Global User Interface)�6   $��788,10,104.6,510.8q�6@   ���	#FF626262���	#FF323232
���   �$��44(�6�   $��Normal"�6�   $
��Auto��6�   $��0q�6�    5        5      $ 9Q�6#   5      �� 5   
   -   5        $��×��5      $��Global User Interface)�6   $��859,10,34.6,510.8q�6@   
���  �����	#FF850000
���   �$��44(�6�   $��Normal"�6�   $
��Auto��6�   $��0q�6�    5        5      $ 9Q�6#   5      �� 5   
   $��39,162,34.6,-0.2q�6   .+�5      �� -   5         ��Name$ textBoxName��5      $��Center=�6+   $	��335��6H   $��26��6T   
����������	#FF8AC4D0)  #MaterialDesignThemes.Wpf.HintAssist	   Hint$	 Ім'я��6�   $
��22.5(�6�   $��8,0,0,0q�6�   $��Roboto)�6�      MaterialDesignTextBox#��[  6�   $��255,0,255,0q�6  �� 5      -   5        $ textBoxSurname��5      $��255,15,255,0q�6.   $��Center=�6D   $	��335��6a   $��26��6m   
����������	#FF8AC4D0$	 Прізвище��6�   $
��22.5(�6�   $��8,0,0,0q�6�   $��Roboto)�6�   #��[  6  �� 5      -   5        $ textBoxLastname��5      $��255,15,255,0q�6/   $��Center=�6E   $	��335��6b   $��26��6n   
����������	#FF8AC4D0$	 Побатькові��6�   $
��22.5(�6�   $��8,0,0,0q�6�   $��Roboto)�6�   #��[  6  �� 5      -   5        $ textBoxPhone��5      $��255,15,255,0q�6,   $��Center=�6B   $	��335��6_   $��26��6k   
����������	#FF8AC4D0$	 Телефон��6�   $
��22.5(�6�   $��8,0,0,0q�6�   $��Roboto)�6�   #��[  6  �� 5       -   5        
 ��Name$
 comboBoxPost��5       $��255,15,255,0q�6-   $��Center=�6C   $	��335��6`   $��27��6l   
����������	#FF8AC4D0$	 Посада��6�   $
��22.5(�6�   $��8,0,0,0q�6�   $��Roboto)�6�     MaterialDesignComboBox#��[ 6  �� 5!      -   5        $
 comboBoxDepartment��5!      $��255,15,255,0q�63   $��Center=�6I   $	��335��6f   $��26��6r   
����������	#FF8AC4D0$%	 Номер відділення��6�   $
��22.5(�6�   $��8,0,0,0q�6�   $��Roboto)�6�   #��[ 6  �� 5"      -	   5        $��272,15,272,0q�5"      $ ��Зареєструвати��6+   $��Center=�6C   ���	#FFF4D160
���   ����	#FFFBEEAC$��21(�6�   $��Roboto)�6�   $��5q�6�   $
��Auto��6�   $	��336��6�   6�   5#      5$      5%      