   M S B A M L   `   `   `  ����  Personal Project    Personal_Project.Task   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      -   5          >�Name$  	TaskEntry��5      $��40��5	      $
��Auto��6    � 	Resources 5         TaskBox �� 
TargetType �� Property �� Value �� 
TargetType �� Stretch A�Name �� Triggers	 P� Property
 P� Value �� 
TargetName ]� 
Conditions �� Property �� Value��%�  &	        �� 5      " ��6   �5      �� 5       � �� 5      �� 5      " ��6   .R�5      � .+�5   	   A� $
��Auto��6   $
��Auto��6   $
 Fill=�6,   
������ ���	#FFEE7A2B$��2��6a   A� 5   	   $ InnerCircle��6   $
��Auto��6&   $
��Auto��64   $��4q�6A   ���	#FFEE7A2B$
 Fill=�6]   5   	    5      P� 5   
   	 �@d�	IsChecked$
 FalseY�6'   . �5      �� $ InnerCircle��6#    � ��
 ���� 6<   5      ]� 5   
    5      �� 5       �@J�IsMouseOver . 6-   �� 5       �@d�	IsChecked$ FalseY�6+   ./�5      �� $ InnerCircle��6#    � ��
 �����6<   5      5!      5#      5%      5&      .��5(      � -   5         �Name$ Layout��5(      $��40��6   $
��Auto��6$    � RowDefinitions 5)      �� 5*      $��7* �6   �� 5+      $��5* �6    � ColumnDefinitions 5-      �� 5.      $��30 �6   �� 5/      $
��Auto �6   .+�51   
   �� -   5         ��Name$ check��51      $��0��6"   $��0��6/   $��2��6?   $��30��6P   #���   6�    d� 	IsChecked 6\   ��  �� Path$ 	IsChecked� �� ElementName$ 	TaskEntry��6�   �� 52   
   $��0��6   $��1��6!   $��Medium"�61   $��16(�6E   ���	#FFEE7A2B$
��Left=�6j   $��5,0,0,0q�6�   $��Bottom=�6�   ��6�   �� $ TaskName�$ 	TaskEntry���� 53   
   $��1��6   $��1��6!   
�������$
��Left=�6C   $	��Top=�6^   $��5,0,0,0q�6v   $��13.333(�6�   ��6�   �� $ TaskTime� �� StringFormat$" {0:MMMM dd, yyyy - hh:mm tt}��$ 	TaskEntry��6�   54      55      