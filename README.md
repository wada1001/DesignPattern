# DesignPattern

https://www.oreilly.co.jp/books/9784873119762/

## Strategy (SimUDuck)

is a よりも has aの方が優れることがある  
オーバーライドは優れた考え方ではあるが、再利用性は低くなる  
カプセル化された振る舞いは交換可能で再利用性が高い(関数ポインタでも代用ができる)  

## Observer (WeatherApp)

変化を通知する  
不変な部分を見定めて変更が起こる部分と分離する  
追加や変更において既存の部分の変更を少なく  

## Decorator ()

OpenClosedの原則。全てに適用ではなく、最も変化する可能性の高い場所に目を向ける  
DecoratorはComponentの代役であるため継承する  
返却を配列で行うようにすれば順番の制御は容易い  
小さなクラスが大量にできる可能性がある  
また、構造の複雑化により生成管理が難しくなりうる  
それはFactory、Builderとの併用で軽減できる  


