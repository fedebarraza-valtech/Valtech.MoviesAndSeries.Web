<template>
  <v-card dark>
    <div class="d-flex flex-no-wrap justify-space-between">
      <div>
        <v-card-title class="headline">{{ model.movieTitle.value }}</v-card-title>

        <v-card-subtitle>{{ model.brand.value }}</v-card-subtitle>

        <v-card-text>{{ model.description.value }}</v-card-text>
      </div>

      <v-avatar class="ma-5" width="auto" height="auto" tile>
        <v-img :src="model.image.value.url"></v-img>
      </v-avatar>
    </div>

    <v-card-actions>
      <v-btn text>{{model.ctaLabel.value}}</v-btn>
    </v-card-actions>
  </v-card>
</template>

<script>
export default {
    props: ['model'],
};
</script>
