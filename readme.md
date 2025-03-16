# Together Hub

## Это шаблон проекта, который будет разрабатываться в рамках воркшопа на платформе Stepik: [присоединяйтесь](https://stepik.org/a/229549/pay?promo=608773466d844860&utm_source=dhub&utm_medium=git&utm_campaign=sale_start&utm_term=cqrs&utm_content=gh) 🙏

## Следить за акциями и специальными предложениями в [Telegram](https://t.me/+DUbX9jlu7T0xOTEy)

### Для ознакомления:  
[Docker-образ](https://hub.docker.com/r/iksergey/together-hub)  
Swagger по маршруту `http://localhost:<PORT>`

![cqrs clean architecture domain driven design ddd](./assets/cqrs-promo.png)

**Together Hub** — это платформа для создания и управления топиками с интегрированной системой аутентификации и авторизации, построенная на **.NET**.

В репозитории есть шаблон проекта. При необходимости можете воспользоваться скриптами для автоинициализации всей структуры.

Воизмежание проблем при создании проекта убедительная просьба использовать .NET 9. При желании потом можно обновиться до полее поздних версий.

## Скрипты для инициализации проекта

В репозитории доступны два скрипта для автоматической настройки проекта:

### Для Mac/Linux
Используйте bash-скрипт `setup-dotnet-project.sh`:

```bash
# Сделать скрипт исполняемым
chmod +x setup-dotnet-project.sh

# Запустить скрипт
./setup-dotnet-project.sh
```

### Для Windows
Используйте PowerShell-скрипт `setup-dotnet-project.ps1`:

```powershell
# Разрешить выполнение скриптов (от администратора)
Set-ExecutionPolicy RemoteSigned

# Запустить скрипт
.\setup-dotnet-project.ps1
```

## Что делают скрипты

- Создают структуру проекта
- Добавляют необходимые NuGet-пакеты
- Настраивают связи между проектами
- Инициализируют базу данных
- Создают начальные миграции

## Важные замечания

- Для Windows: если возникает ошибка выполнения скрипта, убедитесь что PowerShell запущен с правами администратора
- Для Mac/Linux: если скрипт не запускается, проверьте права на выполнение (`chmod +x`)
- В обоих случаях должен быть установлен .NET SDK версии 8 или выше


## Архитектура проекта

Проект построен с использованием **Clean Architecture**, применяющей подходы:

- **CQRS (Command Query Responsibility Segregation)**
- **Mediator Pattern**
- **Domain-Driven Design**

### Слои архитектуры

- **Domain**: Содержит основные сущности, value objects и бизнес-правила.
- **Application**: Отвечает за бизнес-логику и реализацию процессов, таких как команды и запросы.
- **Infrastructure**: Реализует взаимодействие с базой данных, внешними сервисами и поддерживает Identity.
- **API**: Включает контроллеры и конфигурацию веб-приложения.

## Технологический стек

- **Backend**: .NET 9
- **ORM**: Entity Framework Core 
- **База данных**: SQLite -> PostgreSQL 
- **Аутентификация**: ASP.NET Core Identity с поддержкой JWT
- **Паттерны**: CQRS, Mediator
- **Валидация**: Кастомный middleware для проверки входных данных
- **Паттерны**: CQRS, Mediator, Repository 

## Ключевые особенности реализации

## Особенности реализации

- **Использование Value Objects**: Для работы с идентификаторами и значениями, обеспечивая безопасность и неизменяемость данных.
- **Поддержка мягкого удаления (Soft Delete)**: Удаленные сущности сохраняются в базе, но становятся недоступными.
- **Расширенная обработка исключений**: Централизованный обработчик с формированием стандартизированных JSON-ответов.
- **Гибкая система авторизации**: Реализация и настройка политик и требований.
- **Автомаппинг DTO и сущностей**: С использованием AutoMapper для упрощения преобразования данных между слоями.

### Бизнес-логика
- Регистрация и аутентификация пользователей
- Создание и управление топиками
- Система ролей участников (организатор, спикер, участник)
- Комментирование топиков

## Workflow приложения

1. Регистрация пользователя
2. Получение JWT-токена
3. Создание топиков
4. Присоединение к топикам
5. Добавление комментариев

## Преимущества проекта

- **Чистая архитектура**: Четкое разделение ответственности между слоями.
- **Современные подходы разработки**: Использование CQRS и DDD-подходов.
- **Легкость масштабирования**: Благодаря MediatR и независимости слоев.
- **Фокус на безопасности**: Использование ASP.NET Identity и JWT.

**Проект демонстрирует современный подход к разработке backend-приложений с акцентом на чистую архитектуру и принципы Domain-Driven Design**
