// Caution! Be sure you understand the caveats before publishing an application with
// offline support. See https://aka.ms/blazor-offline-considerations

self.importScripts('./service-worker.published.js');

// Cache name
const CACHE_NAME = 'stanpaca-etalage-v1';

// Files to cache
const urlsToCache = [
  './',
  './index.html',
  './manifest.json',
  './css/app.css',
  './Stanpaca.Etalage.styles.css',
  './_content/MudBlazor/MudBlazor.min.css',
  './_content/MudBlazor/MudBlazor.min.js',
  './_framework/blazor.webassembly.js',
  './data/products.json',
  './icon-512.png',
  './icon-192.png'
];

// Install event - cache files
self.addEventListener('install', event => {
  event.waitUntil(
    caches.open(CACHE_NAME)
      .then(cache => cache.addAll(urlsToCache))
  );
});

// Fetch event - serve from cache, fall back to network
self.addEventListener('fetch', event => {
  event.respondWith(
    caches.match(event.request)
      .then(response => response || fetch(event.request))
  );
}); 