   M S B A M L   `   `   `  ����)  %Edge.Applications.PM.SchedulerControl/    )Edge.Applications.PM.SchedulerControl.Log   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$	  Log��5   	    � WindowState$ 	Maximized=�6   .��5      �  � RowDefinitions 5      �� 5      $	��140 �6   �� 5      $��* �6    � ColumnDefinitions 5
      �� 5      $��* �6   .+�5      �  � Orientation$ 
Horizontal=�6   .+�5      � $ Vertical=�6   $��0��6&   $��0��66   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $	��100��6   .��6   ParentInstanceID:6,   �� 5      $	��150��6   {�.  ��6-   ��  �� Path$) #ServiceHistoryView.ParentInstanceID�5      �� 5      $ 
Horizontal=�6   .+�5      �� $	��100��6   .��6   InstanceID:6&   �� 5      $	��150��6   {�.  ��6-   �� $# ServiceHistoryView.InstanceID�5      �� 5      $ 
Horizontal=�6   .+�5      �� $	��100��6   .��6   Service Name:6(   �� 5      $	��150��6   {�.  ��6-   �� $$ ServiceHistoryView.ServiceName�5      �� 5      $ 
Horizontal=�6   .+�5      �� $	��100��6   .��6   
AccountID:6%   �� 5      $	��150��6   {�.  ��6-   �� $" ServiceHistoryView.AccountID�5      �� 5      $ 
Horizontal=�6   .+�5       �� $	��100��6   .��6   
Outcome:6#   �� 5!      $	��150��6   {�.  ��6-   �� $  ServiceHistoryView.Outcome�5"      5#      5$      �� 5%      $ 
Horizontal=�6   $��1��6)   $��0��66   .+�5&      ��  �� TextWrapping$
 Wrap=�6    �� AcceptsReturn . "	 �� VerticalScrollBarVisibility$	 Visible=�66   ��6\   �� *
LogMessage+5'      5(      5*      