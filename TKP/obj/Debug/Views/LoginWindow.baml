   M S B A M L   `   `   `  ����>  :TKP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:TKP.ViewModelTKP.ViewModel  5   	   %clr-namespace:TKP.Views	TKP.Views  5   	       TKP.Views.LoginWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Z VDevExpress.Mvvm.UI, Version=17.1.0.0, Culture=neutral, PublicKeyToken=382ad28f6ae31f30W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *vmclr-namespace:TKP.ViewModel     5   	   )localclr-namespace:TKP.Views     5   	     � WindowState$  Normal=�5	   	    � WindowStartupLocation$ CenterScreen=�5
   	      LoginWindowStyle#��[  5   	    � Title$ Вход��5   	   $	��450��6   $	��600��6#    � DataContext 5      "   TKP.ViewModel.LoginViewModel  5   
   .��5      � ��5   
   �� 5       �� ImageSource$% /TKP;component/Images/bg/bg.jpg��6   .+�5   
   � 
���   � J� Opacity$
 0.65Q�6"   � 5   
   .+�5      � 
�������$	��410��6(   $
�� 590��65   � 5      $	��100��6   $	��600��6    $��	0,250,0,0q�6,   .+�5      �� -   5        $��16(�5   3   $��Center=�6A   $��0q�6\   $��Segoe UI)�6p   $��Вход��6�   $	��200��6�   $��40��6�   ���	#FF00C9F5
���������6   �� *Login+6�   5       �� 5"       �� Orientation$ Vertical=�6   $��Center=�60   $	��170��6K   .+�5$      �� -   5         ��Name$ txtUsername��5$      
 � Tag$ Email��6/     LoginBaseTextBox#��[ 5%   Y   $	��350��6�   $��35��6�   ��6   �� *InputTextUser+	 �� UpdateSourceTrigger$	 PropertyChanged=�6�   �� 5'      .+�5)      G� -   5        
 G�Name$
 txtPassword��5)   #   $ Пароль��68   $	��350��6G   $��35��6T   $��20q�6`   �� 5+      $ 
Horizontal=�6!   $��Center=�6;   .+�57      ��   LoginTextBox#��[ 6$   $*��$Зарегистрироваться��6K   $��5q�6e    J� InputBindings 58      d� 59   "    d� MouseAction$ 	LeftClicke�6M    �� Command 6/   �� *
Register+6M   5;      5>      �� 5@      .+�5A      �� $y�Hidden=�6    $��8q�64   $��Center=�6?   $L��FЛогин или пароль введены не правильно!��6\   
���  ��6�   5B      5D      5F      5H      5I      5J      