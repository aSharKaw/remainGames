Unity Latest Version:4.5.1  
命名規則  
========
**[データ]**
<dl>
    <dt>フォルダ名</dt>
    <dd>キャメル式</dd>
    <dd>Assets</dd>
    <dd>ProjectSettings</dd>
    <dt>ファイル名</dt>
    <dd>最初小文字+キャメル</dd>
    <dd>playerImage.png</dd>
    <dd>Audioデータは</dd>
    <dd>titleBGM.mp3</dd>
    <dd>titleSE.wav</dd>
</dl>
**[スクリプト]**
<dl>
    <dt>グローバル</dt>
    <dd>キャメル型</dd>
    <dt>ローカル</dt>
    <dd>一文字目小文字+キャメル型</dd>
    <dt>定数</dt>
    <dd>全大文字</dd>
    <dt>他</dt>
    <dd>Inspectorに投げたいときはPublicではなく[SerializeField]を利用してください</dd>
</dl>
**[hiramasaメモ]**
<dl>
    <dd>unsafeは使わないでください。</dd>
    <dd>どんなものかというとポインターです。C#では使用を推奨してないです。</dd>
    <dd>pushするファイルは各メンバーそれぞれAssetsのみです。(私だけ+ProjectSettings。)</dd>
    <dd>それ以外をpushしてプルリクを送るとコンフリクトがたまにおきます。</dd>
    <dd>ファイルの命名規則はModel+Prefab+自動生成された物のみ先頭大文字でOK。</dd>
    <dd>プラットフォームはiOSのiPadです。</dd>
    <dd>実機で動かしたら違う挙動になることがよくあります。LINEで連絡していただければiPadminiで実機テストします。</dd>
    <dd>iOSでビルドする際、AppID+認証許可書いうものが必要になります。</dd>
    <dd>つまり学校でMac+iPadを借りても実機でビルドできません。</dd>
    <dd>目でを動作を確認したかったら私に連絡してください。渋渋バンタン行ってやります。</dd>
</dl>
