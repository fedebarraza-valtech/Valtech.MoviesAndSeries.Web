﻿<!--
    Renders the Vue router view. The router.js is configured to always load
    `PageComponentSelector`.

    * Views/DefaultPage/Index.cshtml outputs this component.

    Compared to Preview.vue, this does not use the content link, but uses the
    page's friendly URL instead.
-->

<template>
  <v-app>
    <v-app-bar dark app>
      <v-app-bar-nav-icon></v-app-bar-nav-icon>
      <router-link class="link" to="/">
        <v-toolbar-title>
          Movies and Series
        </v-toolbar-title>
      </router-link>
    </v-app-bar>

    <!-- Sizes your content based upon application components -->
    <v-main>
      <!-- Provides the application the proper gutter -->
      <v-container fluid>
        <!-- If using vue-router -->
        <router-view></router-view>
      </v-container>
    </v-main>

    <v-footer app>
      <!-- -->
    </v-footer>
  </v-app>
</template>

<style lang="scss" scoped>
  @import "/scss/_colors.scss";

  .link {
    text-decoration: none;
    color: $white;

    &:hover {
      text-decoration: underline;
    }
  }
</style>
