
<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<VUEJS>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

********************* COMPUTED ************************* 
A computed property is used to make the code easier and convenient to use. This makes 
out template code more readable, we use the property to reduce the complex or blotted 
logic that we write in our template. We can go for inline expression or interpolation 
if we have simple logic like string concatenation or Boolean expression but for more 
complex logic we should opt for a computed property in Vue.js.

********************** COMPONENET **********************
Components are one of the most powerful features of Vue.js. They help you extend 
basic HTML elements to encapsulate reusable code. At a high level, Components are 
custom elements that Vue.js’ compiler would attach specified behavior to. In some 
cases, they may also appear as a native HTML element extended with the special is attribute.

******************** CLI *******************************
globaaly installed npm package and provide vue commanad in terminal it provide ability to quickly scaffold a new project via projct using gui.
vue cli aims to be standered tooling baseline for the vue ecosystem it ensure the various build tools work smoothly together with sensible.

********************* V-MODEL **************************
v-model directive to create two-way data bindings on form input, textarea, and select elements. ... v-model will ignore the
initial value , checked , or selected attributes found on any form elements. It will always treat the Vue instance data as the source of truth.

******************** EVENTS ****************************
v-on events is used to listent what we are doing on keyboard and on mouse 

******************* Callback ***************************
A callback is a function that is to be executed after another function has finished executing 

*********************** Axios **************************
Axios is a popular, promise-based HTTP client that sports an easy-to-use API and can be used in both the browser and 
Node. js. Making HTTP requests to fetch or save data is one of the most common tasks a client-side JavaScript application will need to do.

********************* Promise **************************
A promise is an object that may produce a single value
Promise users can attach callbacks to handle the fulfilled value or the reason for rejection.
The Promise constructor takes a function (an executor) that will be executed immediately and passes in two 
functions: resolve , which must be called when the Promise is resolved (passing a result), and reject , when it is rejected (passing an error).
State of Promises 1--> Unresolved(Pending) --result not redy 
2--> Resolved (Fulfiled) --result is availible
3-->Rejected --error happend

********************** REnder ***************************
A render function returns a virtual DOM node, commonly named VNode in the Vue ecosystem, which is an interface 
that allows Vue to write these objects in your browser DOM. 

*********************** CSS Scooped **********************
The scoped attribute is a boolean attribute. When present, it specifies that the styles only apply to this element's 
parent element and that element's child elements (not the entire document). 
css scooped is used to apply particular design for particular component it pply design only for this componnent which we are using 

********************* ***Before Guard *********************
Global before guards are called in creation order, whenever a navigation is triggered. Guards may be resolved asynchronously, 
and the navigation is considered pending before all hooks have been resolved. Every guard function receives three arguments: 
to: Route : the target Route Object being navigated to.

**************************** Props ************************
In Vue, props (or properties), are the way that we pass data from a parent component down to it's child components. When we build 
our applications out of components, we end up building a data structure called a tree.

***************** Virtual Dom Vs Dom ********************** 
A virtual DOM object has the same properties as a real DOM object, but it 
lacks the real thing's power to directly change what's on the screen.
Manipulating the DOM is slow. Manipulating the virtual DOM is much faster, because nothing gets drawn onscreen.

Dom:-- Document object model.its abstraction of structured text.
Virtual Dom :- its abstraction of HTML.lightweight and detached from browser
its simple form of html dom.

********************** DATA BINDING ***********************
common need for data binding is manipulating element class list and its inline styles.
in that v-bind is used for class and style.
it keeps your data in sync with your dom without you havind to do anything. 
it has two way of binding data one is binding js variable to dom and another is dom to js.

One Way Data Binding :--
One-way data-binding means the data flows in a single direction so that whenever the data 
changes in a component, it also updates the view with new data.
Two Way Data Binding:-- 
Two-way data binding means data flows in both directions, it means any change happens in 
the view updates the data and any change happens in the data updates the view.

********************** Reactivity **********************
if we did some changes in application it will reflect in the DOM. Vue.js has an adaptable reactive architecture that focuses on declarative rendering of data models and component composition.
it use 
Component render

***************** SPA vs MPA ***************************
sigle page contain one html page.dont need to reload the page.its fast only loded once 
throught the lifespan data is transmitted back and forth.its easy to debug in chrome .
easir to make mobike application.

MPA :- muliple page application contain multiple pages it reload the page for new page . 
bigger than spa. good and easy for seo mangers. gives better chance to rank keyword.

********************* WHy Vuejs ************************
its used to create single page application this framework uses high coupling allows to create 
user interfaces.its an open source javascript framework. it support component based approcah
to build web apps single page application independatn and lossely coupled to enable better code reuse and 
quick devlopment.

******************** Vue Instances *********************
A Vue.js application starts with a Vue instance. The instances object is the main 
object for our Vue App. It helps us to use Vue components in our application. A Vue 
instance uses the MVVM (Model-View-View-Model) pattern. The Vue constructor accepts a single JavaScript object called an options object.

***************** File Structure ***********************
ASSETS:--— Where you put any assets that are imported into your components like image logo.
COMPONENTS:-— All the components of the projects that are not the main views
MIXINS:--— The mixins are the parts of javascript code that is reused in different components. 
In a mixin you can put any component’s methods from Vue.js they will be merged with the ones of the component that uses it.
ROUTER:--— All the routes of your projects (in my case I have them in the index.js). Basically in Vue.js everything is a component. 
But not everything is a page. A page has a route like “/dashboard”, “/settings” or “/search”. If a component has a route it is routed.

*************** Vue App Project Life Cycle *************

1) Package.json:--- package.json is a file that contains information about your project (name, version, etc) and it lists the packages that your project is dependent on.
^ sign before the version tells npm that if someone clones the project and runs npm install in the directory then install the latest minor version of the package in his node_modules.

Semantic Version :-- way of versioning package. EG:-- 2.3.5
Eg:- 2.>>> Major Feature 3.>>>Minor Feature 5.>>>Bug Fixes/Patch Version

6) Package Lock Json:--package-lock.json will simply avoid this general behavior of installing updated minor version so when someone 
clones your repo and run npm install in their machine. NPM will look into package-lock.json and install exact versions of the package as 
the owner has installed so it will ignore the ^ and ~ from package.json.
Also, it contains some other meta information which saves time of fetching that data from npm while you do npm install.

2) Main.js:-- - Entry point of vuejs app. This is usually the JavaScript file that will initialize this root component into
a element on your page. It is also responsible for setting up plugins and 3rd party components you may want to use in your app.
This code creates a new instance of Vue and mounts it on the HTML element with the ID of app.

const app = new Vue().$mount('#app');

Mounting takes place at the Virtual Dom Level, before the User sees anything.
When you $mount('#app'), there will be an 'el' parameter that gets set. This 'el' defines the ID of the element that this instance will be "mounted" to.
So, in your template, if you have an element that you want to be the mounted component, then in your declaration of the component, you would mount it with "el: #app".
In main.js, we're bringing in Vue and rendering the App to our app div in index.html. 

3) App.Vue - This is typically the root of your application defined in Vue Component file format. If App.Vue 
contains Router-view then routing file will be called and a component will be render in index.html according to the provided routes.

4) Index.html - The index page provides your entry point in html providing an element for VueJs to load into and imports main.js to intialise your app.

5) Babel Config :--Babel transforms newer Javascript into old Javascript so that older browsers (notably IE11) can understand it. 
Vue uses Javascript to render DOM nodes. They work together to make it easy to run a javascript application.

********************* Routing **************************
Routing is one of those methods. It allows the user to switch between pages without refreshing the page. This is what makes navigation easy and
Store (optional):-— The Vuex constants in mutation-type.js, the Vuex modules in the subfolder modules (which are then loaded in the index.js).
translations (optional) — Locales files.

********************* ES6 Function *********************
Arrow functions:--. Arrow functions are a new way to declare JavaScript functions. ...
Template Literals:-- it used backticks " istead of double or single qutos.
Destructuring and spread syntax:--- it allows us to unpack object properties and assign 
them to distinct variable.
spread syntaxt allows us to expand and object into a place wherer multiple key value pairs are expected.


*************** Project / Hooks Lifecycle *************
beforeCreate()
This is the very first lifecycle hook that gets called in Vue JS, it gets called immediately after the Vue instance has been initialized.

created()
This is, as you have guessed, the second lifecycle hook that is called right after the beforeCreated hook. At this stage, the Vue instance has been initialized 
and has activated the start of things like computed properties, watchers, events, data properties and manipulations that come with it.

beforeMount()
This is the next lifecycle hook that gets called after the created hook is called. This is the moment immediately before the instance is mounted on the DOM, the template and the scoped styles are all 
compiled here but you still cannot manipulate the DOM yet, the element property is not still available. Here is where initializations that you do not want lying around in your component should go into:

mounted()
This is the next lifecycle hook to be called after the beforeMounted is called. It is called right after the instance has been mounted. Here the app component,
or any other component in the project becomes functional and can now be used. The data is fit into the template, the DOM element is replaced with data filled element and can now be manipulated here, the element property is now available for use.

beforeUpdate()
This is the lifecycle hook called after the mounted hook, anytime a change is made to the data that requires the DOM to be updated. This stage is great for any logic before data changes like removing an event listener.

updated()
This lifecycle hook is called just after a DOM update has occurred, so this means immediately after the beforeUpdate hook is called. DOM related operations can be performed here, although it is not advisable to change state inside this hook as Vue already provides platforms specifically for that.

beforeDestroy()
This Vue lifecycle hook is called just before a Vue instance is destroyed, the instance and all the functionalities are still intact and working here. This is the stage where you can do resource management, delete variables and clean up the component.

destroyed()
This is the final stage of the Vue lifecycle where all the child Vue instances have been destroyed, things like event listeners and all directives have been unbound at this stage. It gets invoked after running destroy on the object.

************** Conditional Rendering *******************
v-if
v-els
v-for
v-show displaying element.

******************** List Rendering ********************
We can use the v-for directive to render a list of items based on an array. The v-for directive requires a special syntax in the form of item in items, where items is the source data array and item is an alias for the array element being iterated on:

********************* Event Handling *******************
V-on:Click ,stop ,prevent ,self, passive

********************* Event Bus ************************
An Eventbus is a mechanism that allows different components to communicate with each other without
knowing about each other. ... Components can also listen to Events on an Eventbus, without knowing who sent the Events.
event bus is a Vue. js instance that can emit events in one component, and then listen and react to the emitted event 
in another component directly — without the help of a parent component
Eventbuses are useful when you don't want components to depend on each other. Instead of a component having many references
to other components, it can just send Events to an Eventbus and does not have to worry about who will take care of them

*********************** $Emit **************************
use $emit() to notify the parent component that something changed

********************** Directive ***********************
a directive is some special token in the markup that tells the library to do something to a DOM element.
They are prefixed with v-.

******************** SCSS ******************************
SASS (Syntactically Awesome Stylesheets) is a CSS pre-processor that lets you use variables, mathematical operations, mixins, loops, functions, imports, and other interesting functionalities that make writing CSS much more powerful.
Scss is more expressive. proper nesting of rules , allow user to write better inline documentetion , integrating css is much easiere.

********************* Types of Router ******************
nested router : mulitple Routing 
named view:-- Displaying mutliple vies 
redirect and alias :-redirect the route like page .
navigation guard :- it allows you to redirect or cancel the event .
router instances :- 

*************** HAsh Mode *******************************
it uses a character # before the actual URL that is internally passed.
The default mode for vue-router is hash mode - it uses the URL hash to simulate a full URL so that the page won't be reloaded when the URL changes. ... If the URL doesn't match any static assets, it should serve the same index. html page that your app lives in.

******************************** El *********************
The vue el option is used to give vuejs an existing html element to which to 
mount for the Vue instance that is created with the new keyword. The use of the el option 
will result in the Vue instance being compiled right away, which might be desirable in most use case examples.

************************** Refs *************************

Refs are Vue.js instance properties that are used to register or indicate a reference to HTML 
elements or child elements in the template of your application. If a ref attribute is added 
to an HTML element in your Vue template, you’ll then be able to reference that element or even a child element in your Vue instance.

***************************** Slots **********************
Slots are a mechanism for Vue components that allows you to compose your components in a way other than the strict parent-child relationship. Slots give you an outlet to place content in new places or make components more generic.

*********************** Filters *********************
Filters are a functionality provided by Vue components that let you apply formatting and transformations to any part of your template dynamic data.
They don’t change a component data or anything, but they only affect the output.

******************** Store **************************
So that's a store in a nutshell. It's a centralized location for data needed across multiple disparate components with centrally defined rules on how those pieces of data can be changed

******************** XTest **************************
xtest exclude test means it skip the particular test and execute other tests

******************** Describe ************************
its used to define and describe test suits it contain all method to test its starting point of test cases 

******************** XDescribe ************************
it skip the all test suits from particualr file wherever XDescribe is used. it dint passed test it skip the test suits

******************** ShallowMount() *******************
it dosnt render child component  and dont include child component in test.js

******************** Mount() **************************
it take vue component as first arguments and return via vue instance along with some helper which is used to interact with component instance 
like props, triggers, click etc...

******************** Watch *****************************
it allows one to watch a component and perform action when value of component is changed it observe and react according to data changes
its most useful when asynchronous action will performed. 
it can change one property at a time if multiple property you wanted to change then use compueted property.

******************** Mutation **************************
it change state of vuex Store. its similar to events each mutation has string type and a handler. handeler function is where we perform 
actual state modification and it will receive state as first argument.
you cant call mutation handler directly. for that you need to call store.commit

******************** Action ***************************** 
its similar like mutation instead of mutation the action commit mutation. it contain arbitary async operations action handlere receiev context object which expose the same set of methods propertys on store  

******************** ... Spread Operator ******************
its used to initialise array and object from another array of object.
its used to create copies of existing object with new or updated values to make copy of an object with more properties.

******************** Preflight(Network Tab) ****************
its a CORS request that checks to see if the CORS protocol is understood and server is aware using specific methods and headers its and options requests
using 3 HTTP request Access-control-Request-Method, Access-control-Request-Headers, Origin-Headers 