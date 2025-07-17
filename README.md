# 🎉 EventEase

**EventEase** is a modern Blazor WebAssembly application that allows users to explore, register for, and add new events. The app is designed with component-based architecture, dynamic routing, and a self-created data service that mimics full-stack behavior.

> 🚀 Live App: [https://red-mushroom-0b4b2d010.1.azurestaticapps.net/](https://red-mushroom-0b4b2d010.1.azurestaticapps.net/)

---

## 🧠 About the Project

I created EventEase as a frontend-focused Blazor project to demonstrate my skills in:

- Component design using Razor
- Dependency Injection in Blazor
- Data modeling with C#
- Building and deploying SPA (Single Page Applications) with Azure Static Web Apps
- Dynamic Page Routing in a SPA

The application uses an in-memory service to simulate real-time backend interaction, including event creation, listing, and registration.

---

## 🔧 Features

- 🖼️ Event cards displaying name, image, date, and description
- 🧩 Component-based design with `<EventCard />`
- ➕ Add new events with validation
- 🔁 Navigate to details using dynamic routing
- 🧠 Injected `EventService` for shared state
- ☁️ Deployed using Azure Static Web Apps

---

## 📦 Project Structure

<ul>
  <li><strong>EventEase/</strong>
    <ul>
      <li><strong>Components/</strong>
        <ul>
          <li>EventCard.razor</li>
        </ul>
      </li>
      <li><strong>Models/</strong>
        <ul>
          <li>Event.cs</li>
        </ul>
      </li>
      <li><strong>Pages/</strong>
        <ul>
          <li>EventList.razor</li>
          <li>AddEvent.razor</li>
          <li>Details.razor</li>
        </ul>
      </li>
      <li><strong>Services/</strong>
        <ul>
          <li>EventService.cs</li>
        </ul>
      </li>
      <li><strong>Shared/</strong>
        <ul>
          <li>MainLayout.razor</li>
        </ul>
      </li>
      <li><strong>wwwroot/</strong>
        <ul>
          <li>CSS, icons, images</li>
        </ul>
      </li>
      <li>App.razor</li>
      <li>Program.cs</li>
      <li>EventEase.csproj</li>
    </ul>
  </li>
</ul>



