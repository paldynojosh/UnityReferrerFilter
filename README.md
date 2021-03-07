# UnityReferrerFilter
## これはなに
WebGLでビルドされたUnityアプリが意図しない所から埋め込み実行された時に、プレイを制限するフィルタシーンを提供します.

## インストール
[UnityReferrerFilter.unitypackage](https://github.com/paldynojosh/UnityReferrerFilter/releases)をプロジェクトに追加してください.

## 使い方
1. Pallab/UnityReferrerFilter/UnityReferrerFilterSceneをScenes In Buildの一番上(0)に追加
1. ゲーム本編のタイトルシーンをScenes In Buildの2番目(1)に追加
1. UnityReferrerFilterSceneをScenesのFilterSettingにアタッチされているWebsiteCheckViewのListにアクセスを許可したいサイトのドメイン等を追加
1. [optional] FilterSettingにアタッチされているLinkButtonBridgeに誘導したいリンクがあれば追加
