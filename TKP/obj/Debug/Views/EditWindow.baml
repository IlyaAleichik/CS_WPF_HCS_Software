   M S B A M L   `   `   `  ����>  :TKP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:TKP.Model	TKP.Model  5   	   -clr-namespace:TKP.ViewModelTKP.ViewModel  5   	       TKP.Views.EditWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Z VDevExpress.Mvvm.UI, Version=17.1.0.0, Culture=neutral, PublicKeyToken=382ad28f6ae31f30W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )modelclr-namespace:TKP.Model     5   	   1	viewmodelclr-namespace:TKP.ViewModel     5   	     � WindowStyle$
  None=�5   	    � 
ResizeMode$ NoResize=�5	   	    � WindowState$ Normal=�5
   	      RegWindowStyle#��[  5   	    � WindowStartupLocation$ CenterScreen=�5   	    � Title$ Изменить��5   	   $	��400��6   $	��700��6&    � DataContext 5      !  TKP.ViewModel.EditViewModel  5   
    � 	Resources 5        DataBase S� 
MethodName S� 
ObjectType   TKP.Model.DataBase��%A   &	       S� 5   
   $ GetInstance��5      "  5      5      .��5K      � .+�5L   
   �� .��5M   
   �� $��20q�6   $��Right=�6!   	 �� Orientation$	 Vertical=�6=   $	��400��6T   .+�5O      �� $��Right=�6   $��	15,0,20,0q�67   $	��290��6J   .+�5P      �� $	 
Horizontal=�6   .+�5Q      �� 
�������$��Здание №��6.   $��10(�6A   6Q   �� 5R      
�������$��Корпус��6.   $��10(�6?   $��4,0,0,0q�6M   6`   �� 5S      
�������$��
По ул.��6.   $��10(�6?   $��12,0,0,0q�6M   6a   5T      �� 5U      $	 
Horizontal=�6   .+�5V      �� $��13(�6"   $��25��6t   $��50��6�   $��5,0,0,0q�6�   ��60   �� *HouseInfo.Num+
 �� UpdateSourceTrigger$
 PropertyChanged=�6�   �� 5W      $��13(�6"   $��25��6u   $��50��6�   $��10,0,0,0q�6�   ��60   �� *HouseInfo.Korp+$
 PropertyChanged=�6�   �� 5X      $��13(�6"   $��25��6x   $	��170��6�   $��5,0,0,0q�6�   ��60   �� *HouseInfo.Address+$
 PropertyChanged=�6�   5Y      5[      �� 5^      $��Right=�6   $��	15,0,20,0q�66   $	��290��6I   .+�5_      �� 
�������$��
Город��6*   $��10(�6:   6J   �� 5`      $��13(�6   $��25��6m   ��6(   �� *HouseInfo.City+$
 PropertyChanged=�6m   5a      �� 5b      $��Right=�6   $��	15,0,20,0q�66   $	��290��6I   .+�5c      �� 
�������$��Собственник��6*   $��10(�6@   6P   �� 5d      $��13(�6   $��25��6r   ��6,   �� *HouseInfo.Owner+$
 PropertyChanged=�6r   5e      �� 5f      $��Right=�6   $��	15,0,20,0q�66   $	��290��6I   .+�5g      �� 
�������$=��7Эксплуатационная организация��6*   $��10(�6Q   6a   �� 5h      $��13(�6   $��25��6s   ��6,   �� *HouseInfo.ExpOrg+$
 PropertyChanged=�6s   5i      �� 5j      $��Right=�6   $��	15,0,20,0q�66   $	��290��6I   .+�5k      �� 
�������$"��Общие сведения:��6*   $��15(�6D   6T   5m      �� 5p      $	 
Horizontal=�6   $��Right=�63   $��	15,0,20,0q�6P   $	��290��6c   .+�5q      �� 
�������$��Год постройки��6*   $��10(�6B   6R   �� 5r      $��13(�6   $��25��6s   $��49��6   ��6,   �� *HouseInfo.Year+$
 PropertyChanged=�6   �� 5s      
�������$��материал стен��6*   $��10(�6B   6R   �� 5t      $��13(�6   $��25��6v   $��88��6�   ��6,   �� *HouseInfo.MatWalls+$
 PropertyChanged=�6�   5u      �� 5z      $	 
Horizontal=�6   $��Right=�63   $��
15,10,20,0q�6P   $	��290��6d   .+�5{      �� 
�������$��Кол-во этажей��6*   $��10(�6B   6R   �� 5|      $��13(�6   $��25��6y   $��30��6�   ��6,   �� *HouseInfo.CountFloor+$
 PropertyChanged=�6�   �� 5}      
�������$#��наличие подвала��6*   $��10(�6D   6T   �� 5~      $��13(�6   $��25��6w   $��75��6�   ��6,   �� *HouseInfo.Basement+$
 PropertyChanged=�6�   5      �� 5�      $	 
Horizontal=�6   $��Right=�62   $��
15,10,20,0q�6O   $	��290��6c   .+�5�      �� 
�������$I��CРезультаты готовности здания к зиме:��6*   $��10(�6Y   6i   �� 5�      $��63��6   $��0q�6&   
�������.@�5�      �� $�� готов ��6    �� 5�      $�� не готов ��6    5�      5�      �� 5�      $��Right=�6   $��
15,10,20,0q�67   $	��290��6K   .+�5�      �� 
�������$)��#Комиссия в составе:��6*   $��15(�6H   6X   �� 5�      .+�5�      �� 
�������$��Председателя:��6.   $��10(�6F   6V   �� 5�      $��13(�6"   $��25��6   ��60   �� *HouseInfo.Predsedateli+$
 PropertyChanged=�6   5�      �� 5�      .+�5�      �� 
�������$#��Представителей:��6.   $��10(�6H   6X   �� 5�      $��13(�6"   $��25��6   ��60   �� *HouseInfo.Predstoviteli+$
 PropertyChanged=�6   5�      5�      �� 5�      $��Right=�6   $��	15,0,20,0q�66   $	��290��6I   �� 5�      $��Right=�6   $��	15,0,20,0q�66   $	��290��6I   .+�5�      �� 
�������$��Описание:��6*   $��10(�6>   6N   �� 5�      $��50��6k    �� TextWrapping$ WrapWithOverflow=�6w   ��6   �� *HouseInfo.Description+$
 PropertyChanged=�6w   �� 5�      $	��150��5�      $��5q�5�      $��Center=�5�      $��Сохранить��5�      ��5�      �� *Save+��5�      ��  �� RelativeSource ��  �� Mode$ FindAncestor=� �� AncestorType" �5�      5�      5�      5�      5�      5�      