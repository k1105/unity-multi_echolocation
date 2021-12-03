# 概要

ユーザのクリックに応じてエコロケーションアニメーションを出力するシェーダー, 及びそのアニメーション処理を行うスクリプト.

<img width="632" alt="スクリーンショット 2021-12-03 9 49 12" src="https://user-images.githubusercontent.com/47634358/144525916-15405d05-c048-4402-a076-21e3a57de1ea.png">

# 使い方

1. リポジトリ内の C#スクリプト, シェーダーをアセットに追加する.
2. 空のゲームオブジェクトを追加して, そこに２つのスクリプト（MultiEcholocationShader, EcholocationTrigger）をアタッチする.
3. シェーダーの発生源となるオブジェクト(Origin)をインスペクター上で指定する.
5. 効果を適用したいオブジェクトに, シェーダーを適用する.

空のゲームオブジェクトの名前を「EcholocationManager」として, OriginにMain Cameraを設定した例.


<img width="457" alt="スクリーンショット 2021-12-03 10 09 16" src="https://user-images.githubusercontent.com/47634358/144527530-a0dbf281-5af8-40ff-ae49-510d55620212.png">
