   M S B A M L   `   `   `  ���� K  GExpress Delivery, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Express_DeliveryExpress_Delivery  "    Express_Delivery.WatchClient   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     0localclr-namespace:Express_Delivery     b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    � Title$  Autorization��$	��587��$	��960�� � WindowStyle$
 None=� � WindowStartupLocation$ CenterScreen=�.��� ���#28527A.+��� $��Image/Menu.png��$	��Top=�$��Center=�$��2��$��	0,0,0.6,0q� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 4Q�   	Direction$	 270Q�   Opacity$
 0.25Q��� $��Клієнти��$��54(�$��Roboto)�$��DemiBold"�$��39,12,339.6,498.8q��� -   $	��←��$��Global User Interface)�$��788,10,104.6,510.8q����	#FF626262���	#FF323232
���   �$��44(�$��Normal"�$
��Auto��$��0q�   $ 9Q��� -   $��×��$��Global User Interface)�$��859,10,34.6,510.8q�
���  �����	#FF850000
���   �$��44(�$��Normal"�$
��Auto��$��0q�   $ 9Q�&   System.Windows.Controls.DataGrid  -     Name$ dataGridClient��$
��Left=�$	��468��$��
39,103,0,0q�$	��Top=�$	��648�� � Cursor$ Arrow��	 J� RenderTransformOrigin$	 0.5,0.5&�
   
IsReadOnly
 . $
��Auto=�$
��Auto=�   AutoGenerateColumns .  ����    Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   CanUserSort .     Header$ Ім'я��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *client_first_name+   .  $ Прізвище�� �� *client_last_name+   .  $! Серія паспорту�� �� *client_pasport+   .  $ Адреса�� �� *client_adress+   .  $ Телефон�� �� *
client_tel+�� $��692,103,34.6,9.8q�.+��� -    ��Name$ textBoxName��$��Center=�$	��227��$��26��
����������	#FF8AC4D0)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Ім'я клієнта��$
��22.5(�$��8,0,0,0q�$��Roboto)�   MaterialDesignTextBox#��[  �� -   $ textBoxSurname��$��0 15 0 0q�$��Center=�$	��227��$��26��
����������	#FF8AC4D0$% Прізвище клієнта��$
��22.5(�$��8,0,0,0q�$��Roboto)�#��[  �� -   $ textBoxPasport��$��0 15 0 0q�$��Center=�$	��227��$��26��
����������	#FF8AC4D0$! Серія паспорту��$
��22.5(�$��8,0,0,0q�$��Roboto)�#��[  �� -   $ textBoxAdress��$��0 15 0 0q�$��Center=�$	��227��$��26��
����������	#FF8AC4D0$ Адреса��$
��22.5(�$��8,0,0,0q�$��Roboto)�#��[  �� -   $��0,15,0,0q�$��Знайти��$��Center=����	#FFF4D160
���   ����	#FFFBEEAC$��21(�$��Roboto)�$��3q�$
��Auto��$	��227���� -	    ��Name$ 
buttonSave��$��0,15,0,0q�$��Зберегти��$��Center=����	#FFF4D160
���   ����	#FFFBEEAC$��21(�$��Roboto)�$��3q�$
��Auto��$	��227��$y�	Collapsed=��� -
   $ 
buttonEdit��$��0,15,0,0q�$��Редагувати��$��Center=����	#FFF4D160
���   ����	#FFFBEEAC$��21(�$��Roboto)�$��3q�$
��Auto��$	��227��