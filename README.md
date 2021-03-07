# UnityReffererFilter
## これはなに
WebGLでビルドされたUnityアプリが意図しない所から埋め込み実行された時に、プレイを制限するフィルタシーンを提供します.

## インストール
[UnityReffererFilter.unitypackage](https://github.com/paldynojosh/UnityReffererFilter/releases)をプロジェクトに追加してください.

## 使い方
1. Pallab/UnityReffererFilter/UnityReffererFilterSceneをScenes In Buildの一番上(0)に追加
1. ゲーム本編のタイトルシーンをScenes In Buildの2番目(1)に追加
1. UnityReffererFilterSceneをScenesのFilterSettingにアタッチされているWebsiteCheckViewのListにアクセスを許可したいサイトのドメイン等を追加
1. [optional] FilterSettingにアタッチされているLinkButtonBridgeに誘導したいリンクがあれば追加
