# RunnerMVC - Project Plan & Prompts

## Project Overview
Educational ASP.NET Core MVC application demonstrating data-passing techniques in .NET 9.

## Learning Objectives
- Master ViewData, ViewBag, and TempData usage
- Understand PRG (Post-Redirect-Get) pattern
- Practice dependency injection with ILogger
- Explore response caching strategies

## Current Features
- [x] Basic MVC structure with HomeController
- [x] ViewData demonstrations
- [x] ViewBag examples
- [x] TempData with redirect scenarios
- [x] Error handling with custom ErrorViewModel

## Planned Enhancements
- [ ] Add more complex model binding examples
- [ ] Implement strongly-typed views
- [ ] Add validation scenarios
- [ ] Create CRUD operations example
- [ ] Add session state demonstrations
- [ ] Include tag helpers examples
- [ ] **Timeline Feature**: Vertical scrollable timeline with interactive events

## Development Notes
- Target Framework: .NET 9
- Pattern: ASP.NET Core MVC
- Language: C# with Spanish UI elements

## AI Prompts / Questions
<!-- Add your development prompts or questions here -->
- How can I improve error handling?
- What's the best practice for TempData vs Session?
- Should I migrate certain features to Razor Pages?

### Timeline Feature Prompt

**Feature Request**: Implementar una línea de tiempo vertical interactiva con las siguientes características:

**Descripción Visual**:
- Línea vertical central que atraviesa la página
- Scroll infinito o paginado hacia abajo
- Marcadores de tiempo organizados por meses/años en secuencia cronológica
- Diseño responsivo y moderno

**Funcionalidad Requerida**:
1. **Estructura de Tiempo**:
   - Dividir la línea en secciones por mes/año
   - Mostrar etiquetas claras de fecha (ej: "Enero 2024", "Febrero 2024")
   - Puntos/nodos en la línea para eventos específicos

2. **Interactividad**:
   - Al hacer hover sobre un mes/año específico:
     - Destacar visualmente esa sección
     - Mostrar ventana emergente (modal/tooltip/popover)
   - La ventana emergente debe contener:
     - Información detallada del evento
     - Fecha exacta
     - Descripción
     - Posibles imágenes o enlaces
     - Botón para cerrar

3. **Datos**:
   - Modelo de datos: `TimelineEvent` con propiedades:
     - `Id`
     - `Fecha` (DateTime)
     - `Titulo`
     - `Descripcion`
     - `Categoria` (opcional)
     - `ImagenUrl` (opcional)
   - Fuente de datos: Base de datos o lista en memoria
   - Cargar eventos ordenados cronológicamente

4. **Tecnologías Sugeridas**:
   - **Backend**: ASP.NET Core MVC Controller con acción que retorne datos JSON
   - **Frontend**: 
     - JavaScript vanilla o Boot para interactividad
     - CSS3 para animaciones y estilos
     - Considerar librerías: 
       - `Timeline.js` (Knight Lab)
       - `Vis.js Timeline`
       - Implementación custom con CSS Grid/Flexbox
   - **AJAX**: Para cargar datos dinámicamente al hacer scroll

5. **Ejemplo de Estructura HTML**:

**Prioridad**: Media  
**Estimación**: 6-10 horas de desarrollo  
**Página**: `/Timeline/Index`

**Ventajas de Alpine.js + Bootstrap 5**:
- ✅ Sin dependencia de jQuery (más ligero y moderno)
- ✅ Sintaxis declarativa fácil de aprender
- ✅ Componentes de Bootstrap 5 listos para usar
- ✅ Reactividad sin complejidad de frameworks grandes
- ✅ SEO-friendly (render server-side inicial)
- ✅ Perfecto para MVC tradicional con interactividad moderna

---

## Resources
- [ASP.NET Core MVC Documentation](https://learn.microsoft.com/aspnet/core/mvc)
- [Passing Data in ASP.NET Core](https://learn.microsoft.com/aspnet/core/mvc/views/overview)
- [Bootstrap 5 Documentation](https://getbootstrap.com/docs/5.3/getting-started/introduction/)
- [Alpine.js Documentation](https://alpinejs.dev/start-here)
- [Alpine.js + Bootstrap Examples](https://alpinejs.dev/plugins/morph)
- [CSS Timeline Examples](https://freefrontend.com/css-timelines/)