<template>
  <v-card dark>
    <div class="d-flex flex-no-wrap justify-space-between">
      <div>
        <v-card-title class="headline">{{ model.heading.value }}</v-card-title>

        <v-card-subtitle>{{ model.description.value }}</v-card-subtitle>
      </div>

      <v-avatar class="ma-3" size="125" tile>
        <v-img :src="model.image.value.url"></v-img>
      </v-avatar>
    </div>

    <v-card-actions>
      <v-btn text>Watch now</v-btn>
    </v-card-actions>
  </v-card>
</template>

<script>
export default {
    props: ['model'],
};
</script>
