<template>
  <div class="col">
    <v-card-title class="headline">{{ model.heading.value }}</v-card-title>
    <div class="d-lg-flex justify-space-between">
      <v-card
        class="mb-md-6"
        v-for="(item, index) in model.news"
        :key="index"
        max-width="344"
      >
        <v-img :src="item.imageUrl" height="200px"></v-img>

        <v-card-title>{{ item.title }}</v-card-title>

        <v-card-subtitle>{{ item.author }}</v-card-subtitle>

        <v-card-actions>
          <router-link class="link" :to="item.linkUrl">
            <v-btn text>Read More</v-btn>
          </router-link>
        </v-card-actions>
      </v-card>
    </div>
  </div>
</template>

<script>
export default {
    props: ['model'],
};
</script>

<style lang="scss" scoped>
  @import "/scss/_colors.scss";

  .link {
    text-decoration: none;
  }
</style>
