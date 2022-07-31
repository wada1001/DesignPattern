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

## Decorator (StarBuzzCoffee)

OpenClosedの原則。全てに適用ではなく、最も変化する可能性の高い場所に目を向ける  
DecoratorはComponentの代役であるため継承する  
返却を配列で行うようにすれば順番の制御は容易い  
小さなクラスが大量にできる可能性がある  
また、構造の複雑化により生成管理が難しくなりうる  
それはFactory、Builderとの併用で軽減できる  

## Factory (PizzaStore)

Factoryに作成を追い出すことによって複数の場所でそのFactoryを使うことができる  
色々なところでnewすると変更箇所が増えていく  
Factoryをインスタンス化するかどうかは用途によって決める  
単純なものであればstaticで十分  
継承させてサブクラスで作らせることで恩恵を最大限に受けられる  
FactoryMethodは共通部分がある場合効果があるが、なければFactoryインターフェースを実装するだけでいいか？  
コーンのトッピングはアリだと思う  

