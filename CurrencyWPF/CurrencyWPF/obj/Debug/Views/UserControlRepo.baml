   M S B A M L   `   `   `  ����F  BCurrencyWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:CurrencyWPF.ViewsCurrencyWPF.Views  5      '    !CurrencyWPF.Views.UserControlRepo   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:CurrencyWPF.Views     5      .��5	      � .+�5
   
   �� $��8q�6   .+�5      ��   �� Orientation$  
Horizontal=�6   $��8q�62   .+�5      �� .��6   Total:6    �� 5      -   5         ��Name$ 	RepoTotal��5      ��6/   �� *	RepoTotal+ �� StringFormat$  {0:c}�� �� Mode$ OneWay=�5      �� 5      $  
Horizontal=�6    � 	Resources 5       �� 
TargetType �� Property �� Value��%W   '��       �� 5      " ��6   .�5      ��  � ��$ 5,0,5,0q�63   5      5      .+�5      �� -   5         ��Name$ 
cbCoinName��5      $��5,0,5,0q�6/   	 �� DisplayMemberPath$
	 Name��6h   $��84��5   7   ��5   @   �� *CoinsforcdCoins+
 �� SelectedItem
 5      �� *
CoinName+67   �� 5      -   5         ��Name$ 
tbNumCoins��5      $��5,0,5,0q�6.   $��22��6Y   ��6@   �� *	CoinNum+6Y   5      �� 5      $��Remove��6   $��	8,30,10,0q�6M   ��6&   �� *RemoveCoinCommand+6M   �� 5      -   5         ��Name$ AddCoin��5      $��10,5,10,147q�6J   $��Add Coin��6_   $
��auto��6r   ��6&   �� *AddCoinCommand+6r   �� 5      $��Reset��6   $��10,-140,10,147q�6K   ��6%   �� *ResetRepoCommand+6K   5      5!      5"      