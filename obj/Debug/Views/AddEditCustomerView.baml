   M S B A M L   `   `   `  ����  BaseWPF'    !BaseWPF.Views.AddEditCustomerView   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .��5      �   � RowDefinitions  5	      �� 5
      $
��Auto �6    �� 5      $
��Auto �6    .+�5   
   � -   5         �Name$ grid1��5      $
��Left=�6   $��	10,10,0,0q�6Z   $	��Top=�6m    � DataContext 69   �� *
Customer+ � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $
��Auto �6#     5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    .+�5      �� $��First Name:��6   $��0��6*   $
��Left=�6:   $��3q�6U   $��0��6`   $��Center=�6m   �� 5      -   5         ��Name$ firstNameTextBox��5      $��1��60   $
��Left=�6@   $��23��6[   $��3q�6g   $��0��6r   $��Center=�6�   $	��120��6�   ��6   �� *	FirstName+" �� ValidatesOnNotifyDataErrors . 6�   �� 5      $��
Last Name:��6   $��0��6)   $
��Left=�69   $��3q�6T   $��1��6_   $��Center=�6l   �� 5      -   5        $ lastNameTextBox��5      $
��Left=�5      $��23��61   $��3q�6=   $��2��6H   $��Center=�6�   $	��120��6�   ��6U   �� *Email+ . 6�   �� 5      $��Phone:��6   $��0��6%   $
��Left=�65   $��3q�6P   $��3��6[   $��Center=�6h   �� 5      -   5        $ phoneTextBox��5      $��1��6,   $
��Left=�6<   $��23��6W   $��3q�6c   $��3��6n   $��Center=�6�   $	��120��6�   ��6{   �� *Phone+ . 6�   5       � 5!   
   $��1��6   .+�5"      �� $
��Save��6   $
��Left=�6D   $��25,5,0,0q�6_   $	��Top=�6q   $��75��6�   ��6$   �� *SaveCommand+6�   �� 5#      $	��Add��6   $
��Left=�6C   $��25,5,0,0q�6^   $	��Top=�6p   $��75��6�   ��6#   �� *SaveCommand+6�   �� 5$      $��Cancel��6   $
��Left=�6H   $��	150,5,0,0q�6c   $	��Top=�6v   $��75��6�   ��6&   �� *CancelCommand+6�   5%      5&      5'      