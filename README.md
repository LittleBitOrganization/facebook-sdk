# Facebook SDK

Модуль предназначен для быстрой и простой интеграции Facebook SDK в проекты.

# Quick Start

1. Создайте и настройте <b> Facebook Settings </b> с помощью меню <b> Facebook/Edit Settings </b>.

![Alt text](https://github.com/LittleBitOrganization/documentation-resources/blob/master/facebook-sdk/documentation-images/edit-settings.png)

Конфиг будет создан по следующему пути - <b> Assets/FacebookSDK/SDK/Resources</b>. Установите значения для необходимых ключей.

2. Для инициализации Facebook через Zenject используйте следующий инсталлер <b> (FacebookInstaller) </b>:

```c#
public override void InstallBindings()
        {
            Container
                .Bind<FacebookInitService>()
                .AsSingle()
                .NonLazy();
        }
```

Инсталлер можно добавить в <b> ProjectContext </b>.