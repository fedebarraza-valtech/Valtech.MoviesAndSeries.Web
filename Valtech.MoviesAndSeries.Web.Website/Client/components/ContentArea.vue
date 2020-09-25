<!--
    Renders a ContentArea by iterating through all the blocks and using the
    `BlockComponentSelector` to render the corresponding Vue component.

    The model property is provided by the page or block that owns the
    ContentArea.
-->

<template>
    <section class="ContentArea">
        <div :key="index" v-for="(block, index) in model">
            <BlockComponentSelector :model="block"></BlockComponentSelector>
        </div>
    </section>
</template>

<script>
import BlockComponentSelector from '@components/BlockComponentSelector.vue';

export default {
    props: ['model'],
    components: {
        BlockComponentSelector
    },
};
</script>
