   M S B A M L   `   `   `  ����K  GRandomGeneration, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:RandomGenerationRandomGeneration  5   	   !    RandomGeneration.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:RandomGeneration     5   	     � Title$  	Generator��5   	   $��157.223��6   $��555.924��6,   
���   �.��5	      � .+�5
   
   �� $��0��6   $��Number of characters:��6   
���   �
�������$
��Left=�6c   $��Center=�6~   �� 5   
   -   5         ��Name$ LengthTextBox��5      $��0��6   
���   �
�������$��0,0,0,1q�6\   $
��Left=�6v   $��23��6�   $��
140,14,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $��81��6�   $��Center=�6�   $��47��6�   �� 5   
   -   5         ��Name$ GenerateBtn��5      $��0��6   $��0,0,0,0q�63   
���   �
�������$��Generate��6�   $
��Left=�6�   $��
192,14,0,0q�6�   $	��Top=�6�   $��75��6�   $��23��6�   �� 5   
   -   5        $ Seed1��5      $��1��6   
���   �
�������$��0,0,0,1q�6T   $
��Left=�6n   $��23��6�   $ NoWrap=�6�   $
��Seed��6�   $��Center=�6�   $	��497��6�   �� 5   
   -   5        $ Copy1��5      $��1��6   $��0,0,0,0q�6.   
���   �
�������$	��⎘��6�    � ToolTip$ Copy to clipboard��6�   $
��Left=�6�   $��512,63,0,236q�6�   $��Center=�6�   $��20��6�   $��20��6  �� 5   
   -   5         ��Name$ InteractionIndicator��5      $��Copied��6.   $y�Hidden=�6?   
�������
���   �$��56(�6y   $
��Left=�6�   $��172,116,0,0q�6�   $	��Top=�6�   $��84��6�   $	��184��6�   �� 5   
   -   5        $ InteractionIndicatorSeed��5      $��Copied��62   $y�Hidden=�6C   
�������
���   �$��11(�6}   $
��Left=�6�   $��Center=�6�   $��
10,209,0,0q�6�   $	��Top=�6�   $��31��6�   $	��497��6  �� 5   
   -   5         ��Name$ 	InfoBarBG��5      
�������$y�Hidden=�64   $
��Left=�6H   $��25��6c   $��
407,-1,0,0q�6o   
���   �$	��Top=�6�   $	��100��6�   �� 5   
   -   5        $ LabelSymbol��5      $	��✓��6%   $y�Hidden=�61   $
��Left=�6E   $��
412,-1,0,0q�6`   $	��Top=�6t   $��25��6�   �� 5   
   -	   5        $ 	LabelText��5      $��Copied��6#   $y�Hidden=�64   $
��Left=�6H   $��
431,-1,0,0q�6c   $	��Top=�6w   $��25��6�   �� 5   
   -
   5         ��Name$ DropDownMenu��5      $��0,0,0,0q�6)   
���   �$y�Hidden=�6V   $
��Left=�6j   $��
282,15,0,0q�6�   $	��Top=�6�   $	��120��6�   
���   �
������� J� OpacityMask
 �   �6�   �� 5   
   -   5        $ progressLabel��5   5   $��2��6   $��|||||||||||||��6   
�������$��Center=�6_   $��Center=�6�   $��Center=�6�   $	��497��6�   	 � RowDefinitions	 5    
   �� 5!      $��* �6   �� 5"      $��* �6   �� 5#      $��* �6   5,      5-      