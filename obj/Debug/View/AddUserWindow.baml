   M S B A M L   `   `   `  ����  UserProject%    UserManagementApp.AddUserWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Add User��5   	   $	��200��6   $	��300��6'   .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5	      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��	Username:��6   $��0��6$   $��0��61   �� 5   
   $��0��6Q   $��1��6^   $��0,0,0,10q�6n   ��6   �� *
Username+ �� UpdateSourceTrigger$ PropertyChanged=�6n   �� 5   
   $��Email:��6   $��1��6!   $��0��6.   �� 5   
   $��1��6N   $��1��6[   $��0,0,0,10q�6k   ��6   �� *Email+$ PropertyChanged=�6k   �� 5   
   $��Add User��6   $��2��6G   $��2��6T   ��6$   �� *AddUserCommand+6T   5      5      