   M S B A M L   `   `   `  ����S  OStockOverviewApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:StockOverviewApplication.CustomControl&StockOverviewApplication.CustomControl  5      :    4StockOverviewApplication.CustomControl.StockOverView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Flocal4clr-namespace:StockOverviewApplication.CustomControl     5        � 	Resources  5	       �� 
TargetType �� Property �� Value��%�   '��       �� 5
   
   " ��6   .�5      ��  � ��
 �   �6+   �� 5       � ��
 �����6+   �� 5       � ��$ DemiBold"�6+   5      5      .��5      � 
�������$��5q�6    � RowDefinitions 5   
   �� 5      $��10 �6   �� 5      �� 5      �� 5      �� 5      $��10 �6    � ColumnDefinitions 5   
   �� 5      $	��160 �6   �� 5      $	��120 �6   .+�5   
   �� $	��2,0q�6   $��1��6"   $��0��6/   $
��Left=�6?   $��Center=�6Z   $��Total Number :��6u    �� TextAlignment$
 Left=�6�   $
��Wrap=�6�   �� 5   
   $	��2,0q�6   $��1��6"   $��1��6/   $
��Left=�6?   $��Center=�6Z   $
 Left=�6�   $
��Wrap=�6�   ��6u   �� *TotalNumber+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�6�   �� 5   
   $	��2,0q�6   $��2��6"   $��0��6/   $
��Left=�6?   $��Center=�6Z   $��Total Stock Weight ��6u   $
 Left=�6�   $
��Wrap=�6�   �� 5   
   $	��2,0q�6   $��2��6"   $��1��6/   $
��Left=�6?   $��Center=�6Z   $
 Left=�6�   $
��Wrap=�6�   ��6u   �� *TotalStockWeight+$ PropertyChanged=�$ TwoWay=�6�   �� 5    
   $	��2,0q�6   $��3��6"   $��0��6/   $
��Left=�6?   $��Center=�6Z   $��Total Market Value :��6u   $
 Left=�6�   $
��Wrap=�6�   �� 5!   
   $	��2,0q�6   $��3��6"   $��1��6/   $
��Left=�6?   $��Center=�6Z   $
 Left=�6�   $
��Wrap=�6�   ��6u   �� *TotalMarketValue+$ PropertyChanged=�$ TwoWay=�6�   5"      5#      