   M S B A M L   `   `   `  ���� K  GExpress Delivery, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Express_DeliveryExpress_Delivery  !    Express_Delivery.WatchOrder   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     0localclr-namespace:Express_Delivery     b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    � Title$  Autorization��$	��587��$	��960�� � WindowStyle$
 None=� � WindowStartupLocation$ CenterScreen=�.��� ���#28527A.+��� $��Image/Menu.png��$	��Top=�$��	0,0,0.6,0q� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 4Q�   	Direction$	 270Q�   Opacity$
 0.25Q��� $��Замовлення��$��54(�$��Roboto)�$��DemiBold"�$��39,12,339.6,498.8q��� -   $	��←��$��Global User Interface)�$��788,10,104.6,510.8q����	#FF626262���	#FF323232
���   �$��44(�$��Normal"�$
��Auto��$��0q�   $ 9Q��� -   $��×��$��Global User Interface)�$��859,10,34.6,510.8q�
���  �����	#FF850000
���   �$��44(�$��Normal"�$
��Auto��$��0q�   $ 9Q�&   System.Windows.Controls.DataGrid  -     Name$ dataGridOrderMin��$
��Left=�$	��414��$��
39,103,0,0q�$	��Top=�$	��475�� � Cursor$ Arrow��	 J� RenderTransformOrigin$	 0.5,0.5&�
   
IsReadOnly
 . $
��Auto=�$
��Auto=�   AutoGenerateColumns .  $��14(�����    Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   CanUserSort .     Header$! ПІБ Отримувача��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *order_name_recipient+   .  $# Дата оформлення�� �� *	dateOrder+   .  $% Номер відділення�� �� *order_department_number+  -   $ dataGridOrder��$
��Left=�$	��414��$��519,103,0,0q�$	��Top=�$	��400��$ Arrow��$	 0.5,0.5&�
 . $
��Auto=�$
��Auto=� .     GridLinesVisibility$ 
Horizontal=�$��14(�����     .  $ 
Назва�� �� *Name+   .  $ Інформація�� �� *Information+�� -    ��Name$ 	textBoxID��$��Center=�$	��227��
����������	#FF8AC4D0)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ ID замовлення��$
��22.5(�$��8,0,0,0q�$��Roboto)�   MaterialDesignTextBox#��[  $��39,534,687.6,16.8q��� -   $��271,531,455.6,12.8q�$��Знайти��$��Center=����	#FFF4D160
���   ����	#FFFBEEAC$��21(�$��Roboto)�$��3q�$
��Auto��$	��227���� -    ��Name$ 
buttonEdit��$��503,531,223.6,12.8q�$��Редагувати��$��Center=����	#FFF4D160
���   ����	#FFFBEEAC$��21(�$��Roboto)�$��3q�$
��Auto��$	��227��$y�	Collapsed=�� -    �Name$ gridEdit�����	#66000000$y�	Collapsed=�.+�  -	   $ dataGridEdit��$��
74,229,0,0q�$
��Left=�$	��139��$	��Top=�$	��796��$ Arrow��$	 0.5,0.5&�$
��Auto=�$
��Auto=�$ 
Horizontal=� .  ����     .  $! Дата отримання�� �� *dateReceiving+   .  $# Дата зберірання�� �� *	dateEnd+   .  $ Крихкість�� �� *order_fragility+   .  $' !Зворот документів�� �� *order_return+   .  $&  Місцезнаходження�� �� *order_place+   .  $! ПІБ отримувача�� �� *order_name_recipient+   .  $) #Телефон отримувача�� �� *order_tel_recipient+   .  $% Номер відділення�� �� *order_department_number+�� -
   $ 
buttonSave��$��643,373,83.6,161.8q�$��Зберегти��$��Center=����	#FFF4D160
���   ����	#FFFBEEAC$��21(�$��Roboto)�$��3q�$
��Auto��$	��227��